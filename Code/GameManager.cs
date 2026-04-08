using System.Numerics;
using Sandbox;
using Sandbox.Network;

public sealed class GameManager : Component
{
    protected override void OnStart()
    { 
        if ( Networking.IsHost ) return;

        Networking.CreateLobby( new LobbyConfig()
        {
            MaxPlayers = 4,
            Privacy = LobbyPrivacy.Public,
            Name = "Dev Test"
        });
    }
}