namespace RenderJsonToUI.Extensions
{
    public static class HostExtention
    {
        public static IHost DeserializeJsonToObject(this IHost host, ILogger<StreamReader> logger, IConfiguration configuration)
        {
            try
            {
                using (StreamReader r = new StreamReader(configuration.GetSection("FilePath").Value))
                {
                    string json = r.ReadToEnd();
                    if (string.IsNullOrEmpty(json))
                    {
                        logger.LogWarning("Empty file !");
                        return host;
                    }

                    Page.ListPages = JsonSerializer.Deserialize<List<Page>>(json);
                }
            }
            catch (Exception e)
            {
                logger.LogError(e.ToString());
            }
            return host;
        }
    }
}
