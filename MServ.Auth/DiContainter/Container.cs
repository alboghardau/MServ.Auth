using MServ.Auth.Common.Config;
using MServ.Auth.Common.Interfaces;

namespace MServ.Auth.DiContainter
{
    public class Container
    {
        public ServiceProvider _provider;
        public Container()
        {
            var container = new ServiceCollection();

            container.AddScoped<IConfigManager, ConfigManager>();

            _provider = container.BuildServiceProvider();
        }
    }
}
