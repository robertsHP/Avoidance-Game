using Godot;
using System;

namespace GameScene {
	public class GameOverMessage : Panel {
		private void _on_Button_pressed() {
			GameGlobal.ResetVariables();
			GetTree().ChangeScene("res://Scenes/GameScene.tscn");
		}
	}
}
