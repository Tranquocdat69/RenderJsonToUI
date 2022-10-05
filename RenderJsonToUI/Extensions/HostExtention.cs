using RenderJsonToUIClassLibrary.Utils;

namespace RenderJsonToUI.Extensions
{
    public static class HostExtention
    {
        public static IHost StartDeserialize(this IHost host, IServiceCollection services, IConfiguration configuration)
        {

            string filePath = configuration.GetSection("FilePath").Value;
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                ILogger<StreamReader> logger = serviceProvider.GetRequiredService<ILogger<StreamReader>>();
                JsonUtil.ReadFileThenDeserialize(filePath, logger);
            }
            return host;
        }
    }
}
