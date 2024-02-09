using Godot;
using System;

public partial class ModifiedButton : Button
{
	[Signal]
	public delegate void ModifiedPressedEventHandler(int intToSend);
	[Export]
	private int storedInt;
	public override void _Ready()
	{
		Pressed += ModifiedPressSender;
	}
	public void ModifiedPressSender()
	{
		EmitSignal(SignalName.ModifiedPressed, storedInt);
	}
}
