using Godot;
using System;

namespace GameScene {
	public class GameGlobal : Node2D {
		[Export] public NodePath gameOverMessagePath;
		[Export] public NodePath timeCounterPath;
		
		public static GameOverMessage gameOverMessage;
		public static TimeCounter timeCounter;
		public static bool gameOver = false;
		
		public override void _Ready() {
			gameOverMessage = GetNode<GameOverMessage>(gameOverMessagePath);
			timeCounter = GetNode<TimeCounter>(timeCounterPath);
		}
		public override void _Process(float delta) {
			if(gameOver) {
				gameOverMessage.Show();
			} else {
				gameOverMessage.Hide();
			}
		}
		public static void ResetVariables () {
			gameOver = false;
		}
	}
}
