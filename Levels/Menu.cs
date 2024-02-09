using Godot;
using System;

public partial class Menu : Node2D
{
	[Export]
	private Godot.Collections.Array<Resource> levelFilePaths;
	
	
	public void ChangeLevel(int levelnum)
	{
		//when counting your levels you should start at 0 for level 1 and so on (or levelnum--; in code)
		GetTree().ChangeSceneToFile(levelFilePaths[levelnum].ResourcePath);
	}
}
