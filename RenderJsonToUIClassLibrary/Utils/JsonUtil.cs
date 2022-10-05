namespace RenderJsonToUIClassLibrary.Utils
{
    public class JsonUtil
    {
        public static void ReadFileThenDeserialize(string filePath, ILogger<StreamReader> logger)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    using (StreamReader streamReader = new StreamReader(filePath))
                    {
                        string json = streamReader.ReadToEnd();

                        if (string.IsNullOrEmpty(json))
                            logger.LogWarning("Empty file !");
                        else
                            PageUIUtil.ListPages = JsonSerializer.Deserialize<List<PageUI>>(json);
                    }
                }
                catch (Exception e)
                {
                    logger.LogError(e.ToString());
                }
            }
            else
                logger.LogError("File does not exist !");
        }

        /*var options = new JsonSerializerOptions();
        options.Converters.Add(new CustomDateTimeConverter("yyyy-MM-ddTHH:mm:ss"));*/

        public class CustomDateTimeConverter : JsonConverter<DateTime>
        {
            private readonly string Format;
            public CustomDateTimeConverter(string format) => Format = format;

            public override void Write(Utf8JsonWriter writer, DateTime date, JsonSerializerOptions options)
                => writer.WriteStringValue(date.ToString(Format));

            public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
                => DateTime.ParseExact(reader.GetString(), Format, null);
        }
    }
}
