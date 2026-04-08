using Sandbox;
using Sandbox.UI;
namespace Sandbox;

public class CharacterPanel : Panel
{
    public ScenePanel ScenePanel { get; set; }

    public CharacterPanel()
    {
        ScenePanel = new ScenePanel("scenes/CharacterPreview.scene");
        ScenePanel.Style.Width = Length.Percent( 100 );
        ScenePanel.Style.Height = Length.Percent( 100 );

        AddChild( ScenePanel );
    }
}