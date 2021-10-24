# LoraChatBot

Projeto desenvolvido como teste técnico para a vaga de Pessoa Desenvolvedora na Take Blip.

O repositório consiste no código da API, que se comunica com a API do github para trazer os 5 repositórios mais antigos de um usuário, assim como o fluxo conversacional do Bot. 

O fluxo foi desenvolvido na plataforma da Take Blip usando a ferramenta nativa já desenvolvida.

A API atualmente está hospedada em um  App Service Azure rodando em Linux e pode ser encontrada em:
https://lorachatbotapi.azurewebsites.net

Para testar o funcionamento da api, tente executar uma requisição para:
https://lorachatbotapi.azurewebsites.net/api/github/{seuUsuarioGithub}

Quando clonar o código, certifique-se de instalar o pacote NuGet Newtonsoft.Json
