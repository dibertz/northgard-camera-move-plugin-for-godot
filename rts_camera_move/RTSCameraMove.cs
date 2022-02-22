using Godot;
using System;

[Tool]
public class RTSCameraMove : EditorPlugin
{
    public override void _EnterTree()
    {
        var script = GD.Load<Script>("res://addons/rts_camera_move/SampleScene.cs");
        var texture = GD.Load<Texture>("res://addons/rts_camera_move/ico.png");
        AddCustomType("RTSCameraMove3D", "Spatial", script, texture);
    }

    public override void _ExitTree()
    {
        RemoveCustomType("RTSCameraMove3D");
    }
}
