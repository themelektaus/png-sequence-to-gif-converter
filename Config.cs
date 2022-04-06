using Newtonsoft.Json;

namespace PngSequenceToGifConverter;

public class Config
{
    static Config _instance;
    public static Config instance
    {
        get
        {
            if (_instance is null)
            {
                if (File.Exists("config.json"))
                {
                    var json = File.ReadAllText("config.json");
                    _instance = JsonConvert.DeserializeObject<Config>(json);
                }
                else
                {
                    _instance = new();
                }
            }
            return _instance;
        }
    }

    public static void Save()
    {
        var json = JsonConvert.SerializeObject(instance);
        File.WriteAllText("config.json", json);
    }

    public string imageMagickPath { get; set; } = "ImageMagick";
    public int delay { get; set; } = 2;
    public int loop { get; set; } = 0;
}