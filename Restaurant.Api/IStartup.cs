namespace Restaurant.Api
{
    public interface IStartup
    {
        IConfiguration Configuration { get; }

        void Configure(WebApplication webApplication, IWebHostEnvironment webHostEnvironment);

        void ConfigureServices(IServiceCollection services);
    }
}
