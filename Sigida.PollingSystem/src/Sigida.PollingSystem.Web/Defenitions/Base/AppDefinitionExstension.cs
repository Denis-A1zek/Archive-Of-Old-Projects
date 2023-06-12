namespace Sigida.PollingSystem.Web.Defenitions.Base
{
    public static class AppDefinitionExstension
    {
        public static void AddDefinitions(this IServiceCollection source, WebApplicationBuilder builder, params Type[] entryPointsAssembly)
        {
            var defenitions = new List<IAppDefenition>();

            foreach (var entryPoint in entryPointsAssembly)
            {
                //Выбираем все которые являются наследником IAppDefenition
                var types = entryPoint.Assembly.ExportedTypes.Where(x => !x.IsAbstract && typeof(IAppDefenition).IsAssignableFrom(x));

                //Создаем инстансы
                var instances = types.Select(Activator.CreateInstance).Cast<IAppDefenition>();
                defenitions.AddRange(instances);
            }

            defenitions.ForEach(app => app.ConfigureServices(source, builder.Configuration));
            source.AddSingleton(defenitions as IReadOnlyCollection<IAppDefenition>);
        }

        public static void UseDefenitions(this WebApplication source)
        {
            //Вытаскиваем defenition
            var defenitions = source.Services.GetRequiredService<IReadOnlyCollection<IAppDefenition>>();
            var enviroment = source.Services.GetRequiredService<IWebHostEnvironment>();
            foreach (var endpoint in defenitions)
            {
                endpoint.ConfigureApplication(source, enviroment);
            }
        }
    }
}
