# chatbot-blip-api

Chatbot API Integration

Este projeto é uma integração de API para um chatbot desenvolvido na plataforma BLiP. O chatbot foi configurado para se conectar a uma API pública e apresentar as informações recebidas de maneira dinâmica em formato de carrossel. A solução foi construída utilizando .NET 6 para a API e BLiP Builder para o desenvolvimento do fluxo do chatbot.
Objetivo

O objetivo deste projeto é demonstrar como integrar uma API intermediária com uma API pública (GitHub) a um chatbot Blip e usar os dados retornados da API para exibir informações de forma interativa e dinâmica, utilizando o componente de carrossel.

Funcionalidade

    O chatbot realiza uma requisição HTTP para uma API intermediária que por sua vez consulta uma API pública do GitHub.
    A API retorna dados como: fullName, description, language, avatarUrl e createdAt.
    Estes dados são então exibidos no formato de cards no carrossel do chatbot, onde cada card contém:
        Nome do repositório (fullName)
        Descrição (description)
        Imagem do avatar (avatarUrl) como imagem do card

Como funciona

    Requisição HTTP: O chatbot faz uma requisição HTTP para a API, que retorna um array com os detalhes dos projetos.

    Exibição no Carrossel: As informações dos projetos são convertidas dinamicamente para cards de carrossel, onde cada card exibe os dados mencionados.


Requisitos

    .NET 6 para a construção da API
    Conta no Blip para gerenciamento do chatbot
    Conhecimento básico de como configurar bots no BLiP