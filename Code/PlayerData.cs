using Sandbox;

public class PlayerData
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Rank { get; set; } = "User";
    public int Age { get; set; }
    public string Gender {get; set;}
    public float Cash { get; set; } = 500f;
    public float Bank { get; set; } = 2000f;
    public string PlayerModel { get; set; } = "models/citizen/citizen.vmdl"; // Default model

    public static void Save(PlayerData data, ulong id)
    {
        FileSystem.Data.WriteJson($"{id}_player.json", data);
    }

    public static PlayerData Load(ulong id)
    {
        var path = $"{id}_player.json";
        if (!FileSystem.Data.FileExists(path))
            return null;

        return FileSystem.Data.ReadJson<PlayerData>(path);
    }


}