using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class RepositoriesController : ControllerBase
{
    private readonly HttpClient _httpClient;

    public RepositoriesController(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; Bot/1.0)");
    }

    [HttpGet("csharp-repositories")]
    public async Task<IActionResult> GetCSharpRepositories()
    {
        try
        {
            var url = "https://api.github.com/users/takenet/repos";

            var response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                return StatusCode((int)response.StatusCode, "Erro ao acessar a API do GitHub.");
            }

            var jsonResponse = await response.Content.ReadAsStringAsync();
            var repositories = System.Text.Json.JsonSerializer.Deserialize<List<Repository>>(jsonResponse);

            if (repositories == null || !repositories.Any())
            {
                return Ok("Nenhum repositório encontrado.");
            }

            var csharpRepositories = repositories
            .Where(repo => repo.Language == "C#") 
            .OrderBy(repo => repo.CreatedAt)      
            .Take(5)                              
            .Select(repo => new                   
            {
                repo.FullName,
                repo.Description,
                repo.Language,
                repo.CreatedAt,
                AvatarUrl = repo.Owner.AvatarUrl
            });
            return Ok(csharpRepositories);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro interno: {ex.Message}");
        }
    }

}

