using Godot;
using System;

namespace GameScene {
	public class Enemy : Area2D {
		public enum Direction : int {
			LEFT_UP, RIGHT_UP, RIGHT_DOWN, LEFT_DOWN
		}
		
		[Export] public float speed;
		private RandomNumberGenerator rng;
		public Direction direction;
		
		public override void _Ready() {
			rng = new RandomNumberGenerator ();
			direction = (Direction) rng.RandiRange((int) Direction.LEFT_UP,(int) Direction.LEFT_DOWN);
		}
		public override void _Process(float delta) {
			if(!GameGlobal.gameOver) {
				Move(GetMoveDirectionAsVector(direction));
			}
		}
		private void Move (Vector2 dir) {
			Vector2 pos = GlobalPosition;
			pos.x += dir.x;
			pos.y += dir.y;
			GlobalPosition = pos;
		}
		private Vector2 GetMoveDirectionAsVector (Direction dir) {
			Vector2 moveDir = Vector2.Zero;
			switch(dir) {
				case Direction.LEFT_UP : moveDir = new Vector2(-speed, -speed); break;
				case Direction.RIGHT_UP : moveDir = new Vector2(speed, -speed); break;
				case Direction.RIGHT_DOWN : moveDir = new Vector2(speed, speed); break;
				case Direction.LEFT_DOWN : moveDir = new Vector2(-speed, speed); break;
			}
			return moveDir;
		}
	}
}
