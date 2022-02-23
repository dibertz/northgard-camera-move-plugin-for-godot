// Copyright (c) Dibertz Soft contributors (https://dibertz.com) and Conectividad (Bs.As.) Argentina.
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using Godot;
using System;

public class ahri_base : Spatial
{

    private AnimationPlayer Animator; 

    public override void _Ready()
    {
        Animator = GetNode<AnimationPlayer>("AnimationPlayer");
        Animator.Play("Armature|CINEMA_4D_Principal|Layer0");
    }

    public override void _PhysicsProcess(float delta)
    {
        if (Input.IsActionPressed("ui_left") || Input.IsActionPressed("ui_right") || Input.IsActionPressed("ui_up") || Input.IsActionPressed("ui_down"))
        {
            // Ahri Running
            if ((Animator.IsPlaying() != true) || Animator.CurrentAnimationPosition < 3.7f){
                Animator.Play("Armature|CINEMA_4D_Principal|Layer0");
                Animator.Seek(3.799f);
            }
        }
        else
        {
            // Ahri Idle
            if (Animator.CurrentAnimationPosition > 3.6f)
            {
                Animator.Play("Armature|CINEMA_4D_Principal|Layer0");
                Animator.Seek(0.00f);
            }
        }
    }
    
}
