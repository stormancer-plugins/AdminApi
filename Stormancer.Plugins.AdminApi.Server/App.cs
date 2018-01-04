namespace Stormancer.Server.AdminApi
{
    public class App
    {
        public void Run(IAppBuilder builder)
        {
            builder.AddPlugin(new AdminApiPlugin());
        }
    }
}
