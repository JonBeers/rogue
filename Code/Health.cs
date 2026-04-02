using Sandbox;
using System;

public sealed class PlayerHealth : Component
{
    [Property] public PlayerController Player { get; set; }
    [Property] public PlayerInfo PlayerInfo { get; set; }

    public float MaxHealth { get; set; } = 100f;

    public float Health
    {
        get => PlayerInfo?.Health ?? 0f;
        set { if (PlayerInfo != null) PlayerInfo.Health = value; }
    }

    public float Armor
    {
        get => PlayerInfo?.Armor ?? 0f;
        set { if (PlayerInfo != null) PlayerInfo.Armor = value; }
    }

    protected override void OnStart()
    {
        Health = MaxHealth;
        // Armor = 0f;
    }

    public void TakeDamage(float damage, PlayerController player)
    {
        if (IsProxy) return; // only host applies damage
        if (player == null) return;

        Health = Math.Clamp(Health - damage, 0, MaxHealth);

        if (Health <= 0) OnDeath();
    }

    public void Heal(float amount)
    {
        Health = Math.Clamp(Health + amount, 0, MaxHealth);
    }

    private void OnDeath()
    {
        Log.Info($"{Player?.GameObject.Name} died.");
    }
}
