using Sandbox;

public class PlayerData
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Rank { get; set; } = "User";
    public int Age { get; set; }
    public string Story { get; set; }
    public float Cash { get; set; } = 500f;
    public float Bank { get; set; } = 2000f;

    // ✅ Removed static SelectedCharacter — use Connection.Local.GetUserData() instead

    public static void Save(PlayerData data, ulong id, int slot)
    {
        FileSystem.Data.WriteJson($"{id}_player_slot{slot}.json", data);
    }

    public static PlayerData Load(ulong id, int slot)
    {
        var path = $"{id}_player_slot{slot}.json";
        if (!FileSystem.Data.FileExists(path))
            return null;

        return FileSystem.Data.ReadJson<PlayerData>(path);
    }


}