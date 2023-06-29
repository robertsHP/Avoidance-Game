using Godot;
using System;

namespace GameScene {
	public class Player : Area2D {
		[Export] public float speed;
		[Export] public NodePath spritePath;
		
		public Sprite sprite;
		
		public override void _Ready() {
			sprite = GetNode<Sprite>(spritePath);
		}
		public override void _Process(float delta) {
			if(!GameGlobal.gameOver) {
				if(Input.IsKeyPressed((int) KeyList.W)) {
					Move(0.0f, -speed);
				}
				if(Input.IsKeyPressed((int) KeyList.A)) {
					Move(-speed, 0.0f);
				}
				if(Input.IsKeyPressed((int) KeyList.S)) {
					Move(0.0f, speed);
				}
				if(Input.IsKeyPressed((int) KeyList.D)) {
					Move(speed, 0.0f);
				}
			}
		}
		private void Move (float x, float y) {
			Vector2 pos = GlobalPosition;
			pos.x += x;
			pos.y += y;
			GlobalPosition = pos;
		}
		private void _on_Player_area_entered(object area) {
			GameGlobal.gameOver = true;
		}
	}
}
