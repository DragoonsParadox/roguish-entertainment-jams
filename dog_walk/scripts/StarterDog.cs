using Godot;
using System;

public class DogTemplate : Node
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    //Object mod = {1.0f,1.0f,1.0f,1.0f,1.0f};
    Stats.PT pT = Stats.PT.NONE;
    Stats stats = new Stats(30, 10, 10, 15, 10, 0, 1);
    String name = "Bitch"; 
    int loyalty, dt, health;
    float fatigue;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}