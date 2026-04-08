using Sandbox;

public sealed class PlayerInfo : Component
{
    [Property, Sync] public string PlayerName { get; set; }
    [Property, Sync] public string Rank { get; set; }
    [Property, Sync] public int Age { get; set; }
    [Property, Sync] public float Cash { get; set; }
    [Property, Sync] public float Bank { get; set; }
    [Property, Sync] public float Health { get; set; }
    [Property, Sync] public float Armor { get; set; }
    [Property, Sync] public string Gender { get; set; }

    // ✅ Holds the loaded character data for this player
    public PlayerData CharacterData { get; private set; }

    protected override void OnStart()
    {
        if (IsProxy) return;

        if (Session.PendingCharacter != null)
        {
            LoadFromData(Session.PendingCharacter);
            Session.PendingCharacter = null; // ✅ Clear after use
        }
    }

    public void LoadFromData(PlayerData data)
    {
        if (data == null) { Log.Info("No data found!"); return; }

        CharacterData = data;

        if (!IsProxy)
        {
            PlayerName = $"{data.FirstName} {data.LastName}";
            Rank = data.Rank;
            Age = data.Age;
            Cash = data.Cash;
            Bank = data.Bank;
            Gender = data.Gender;
        }
    }
}

