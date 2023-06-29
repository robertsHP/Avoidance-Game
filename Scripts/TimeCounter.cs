using Godot;
using System;

namespace GameScene {
	public class TimeCounter : Control {
		[Export] public NodePath labelPath;
		
		public Label label;
		public float time;
		
		public override void _Ready() {
			label = GetNode<Label>(labelPath);
			time = 0.0f;
		}
		public override void _Process(float delta) {
			if(!GameGlobal.gameOver) {
				time += delta;
				label.Text = "Time: "+((int)time).ToString();
			}
		}
	}
}
