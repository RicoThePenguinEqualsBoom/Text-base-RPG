using System.Text.Json;
using System.Text.Json.Serialization;

namespace Engine
{
    public static class SaveSystem
    {
        private static readonly string SaveFile = "SuperAdventure.json";

        public static void Save(Player player)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            };

            string json = JsonSerializer.Serialize(player, options);
            File.WriteAllText(SaveFile, json);
        }

        public static Player Load()
        {
            if(!File.Exists(SaveFile))
            {
                return null;
            }

            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            string json = File.ReadAllText(SaveFile);
            return JsonSerializer.Deserialize<Player>(json, options);
        }
    }
}
