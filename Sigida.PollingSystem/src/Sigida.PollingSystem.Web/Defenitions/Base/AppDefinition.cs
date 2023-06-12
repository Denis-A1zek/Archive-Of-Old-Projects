namespace Sigida.PollingSystem.Web.Defenitions.Base
{
    public abstract class AppDefinition : IAppDefenition
    {
        public virtual void ConfigureApplication(WebApplication app, IWebHostEnvironment environment)
        {
            throw new NotImplementedException();
        }

        public virtual void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            throw new NotImplementedException();
        }
    }
}
