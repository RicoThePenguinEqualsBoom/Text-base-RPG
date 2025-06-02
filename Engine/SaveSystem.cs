using System.Text.Json;
using System.Text.Json.Serialization;

namespace Engine
{
    public static class SaveSystem
    {
        private static readonly string SaveFile = "SuperAdventure_save.json";

        public static void Save(Player player, string richTextL, string richTextM, bool autoSaveState)
        {
            SaveData saveData = new SaveData(player, richTextL, richTextM, autoSaveState);

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            };

            string json = JsonSerializer.Serialize(saveData, options);
            File.WriteAllText(SaveFile, json);
        }

        public static SaveData Load()
        {
            if (!File.Exists(SaveFile))
            {
                return null;
            }

            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            string json = File.ReadAllText(SaveFile);
            return JsonSerializer.Deserialize<SaveData>(json, options);
        }

        public static void ResetSave()
        {
            if (File.Exists(SaveFile))
            {
                File.Delete(SaveFile);
            }
        }
    }

    public class SaveData
    {
        public Player Player { get; set; }
        public string RichTextL { get; set; }
        public string RichTextM { get; set; }
        public bool AutoSaveState { get; set; }

        public SaveData() { }

        public SaveData(Player player, string richTextL, string richTextM, bool autoSaveState)
        {
            Player = player;
            RichTextL = richTextL;
            RichTextM = richTextM;
            AutoSaveState = autoSaveState;
        }
    }
}
