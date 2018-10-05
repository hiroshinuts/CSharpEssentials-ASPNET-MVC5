using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Web.Http;

[assembly: OwinStartup(typeof(FuncionariosAPIService.Startup))]
namespace FuncionariosAPIService
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // configuracao WebApi
        var config = new HttpConfiguration();
 
        // configurando rotas
        config.MapHttpAttributeRoutes();
        config.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { id = RouteParameter.Optional }
        );
        // ativando cors
        app.UseCors(CorsOptions.AllowAll);

        //ativando a geração dos tokens de acesso
        AtivarGeracaoTokenAcesso(app);

        // ativando configuração WebApi
        app.UseWebApi(config);
        }

        private void AtivarGeracaoTokenAcesso(IAppBuilder app)
        {
            //cria uma instância das opções de autorização
            var opcoesConfiguracaoToken = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                // uri/token
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromHours(1),
                Provider = new ProviderDeTokensDeAcesso()
            };

            //realiza o processamento do request
            // da autorização e do token
            app.UseOAuthAuthorizationServer(opcoesConfiguracaoToken);
            // compreende formato do token no header da requisicao
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}
