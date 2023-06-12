using Microsoft.EntityFrameworkCore;
using Sigida.PollingSystem.Application;
using Sigida.PollingSystem.Web.Defenitions.Base;

namespace Sigida.PollingSystem.Web.Defenitions.DbContext
{
    public class DbContextDefenition : AppDefinition
    {
        public override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDBContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString(nameof(ApplicationDBContext)));
            });
        }

    }
}
