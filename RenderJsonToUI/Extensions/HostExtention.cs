using RenderJsonToUIClassLibrary.Utils;

namespace RenderJsonToUI.Extensions
{
    public static class HostExtention
    {
        public static IHost StartDeserialize(this IHost host, ILogger<StreamReader> logger, IConfiguration configuration)
        {
            string filePath = configuration.GetSection("FilePath").Value;
            JsonUtil.ReadFileThenDeserialize(filePath, logger);
            return host;
        }
    }
}
