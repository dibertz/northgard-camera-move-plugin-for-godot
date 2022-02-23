// Copyright (c) Dibertz Soft contributors (https://dibertz.com) and Conectividad (Bs.As.) Argentina.
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using Godot;
using System;

[Tool]
public class SampleScene : Spatial
{

    public PackedScene _sampleScene;

    public override void _Ready()
    {
        _sampleScene = (PackedScene)ResourceLoader.Load("res://addons/rts_camera_move/SampleScene.tscn");
        var RTS_Scene = _sampleScene.Instance();
        AddChild(RTS_Scene);
        this.EditorDescription= ("Northgard RTS Camera\nInstructions for Use - Input Map\n\n1. Create the camera zoom input map:\n\n• Wheel Up Button is 'ui_scroll_down'\n• Wheel Down Button is 'ui_scroll_up'\n\n2. Add the character move input map:\n\n• Physical Key A is 'ui_left'\n• Physical Key D is 'ui_right'\n• Physical Key W is 'ui_up'\n• Physical Key S is 'ui_down'\n\n3. Create the lock camera input map:\n\n• Physical Key Y is 'ui_camera'\n\n~Enjoy it!.");
    }

    public void load_rts_scene()
    {

        // Loading new RTS scenes. 

    }
}