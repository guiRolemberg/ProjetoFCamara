# ProjetoFCamara
Teste Desenvolvedor

ProjetoFCamara.API:
Através do Gerenciar do Pacotes NuGet realizar a instação dos seguintes pacotes:
 - Install-Package Microsoft.AspNet.WebApi.Owin
 - Install-Package Microsoft.AspNet.Identity.Owin
 - Install-Package Microsoft.AspNet.Identity.EntityFramework
 - Install-Package Microsoft.Owin.Cors
 - Install-Package Microsoft.Owin.Host.SystemWeb
 - Install-Package Microsoft.Owin.Security.OAuth

Para o teste optei por utilizar o SqlServer Express, com o Entity FrameWork para configuração / acesso ao banco e também a utilização do Migrations FrameWork para criação do Seed. Foi utilizado o conceito de CodeFirst.
Para utilização do Migrations é necessário habilita-lo no projeto através do NuGet console com o comando: "Enable-Migrations" e então utilizar o comando "Update-Database" para efetivação do Seed.

Padrão OAuth para geração /  validação do Token.

ProjetoFCamara.Web:
Através do Gerenciar do Pacotes NuGet realizar a instação dos seguintes pacotes:
 - Install-Package AngularJS.Core
 - Install-Package AngularJs.Route
 - Install-Package Angular-local-storage

Aplicação web com AngularJS que consome a API rest.
