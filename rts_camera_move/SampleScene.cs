using Godot;
using System;

[Tool]
public class SampleScene : Spatial
{

    public PackedScene sampleScene;

    public override void _Ready()
    {
        sampleScene = (PackedScene)ResourceLoader.Load("res://addons/rts_camera_move/SampleScene.tscn");
        var RTS_Scene = sampleScene.Instance();
        AddChild(RTS_Scene);
        this.EditorDescription= ("Northgard RTS Camera\nInstructions for Use - Input Map\n\n1.Configure the camera zoom:\n\n• Wheel Up Button is 'ui_scroll_down'\n• Wheel Down Button is 'ui_scroll_up'\n\n2.Configure the character movement in the Input Map:\n\n• Physical Key A is 'ui_left'\n• Physical Key D is 'ui_right'\n• Physical Key W is 'ui_up'\n• Physical Key S is 'ui_down'\n\n~Enjoy it!.");
    }

    public void load_rts_scene()
    {
        // -- 

    }
}