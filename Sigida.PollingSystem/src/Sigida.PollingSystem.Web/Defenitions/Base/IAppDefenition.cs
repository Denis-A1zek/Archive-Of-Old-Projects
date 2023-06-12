namespace Sigida.PollingSystem.Web.Defenitions
{

    public interface IAppDefenition
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        void ConfigureServices(IServiceCollection services, IConfiguration configuration);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="environment"></param>
        void ConfigureApplication(WebApplication app, IWebHostEnvironment environment);
    }
}
