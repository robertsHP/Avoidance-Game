using Godot;
using System;

namespace GameScene {
	public class BorderDetection : Node2D {
		private void _on_BorderWest_area_entered(object area) {
			DirChange(area, Enemy.Direction.LEFT_UP, Enemy.Direction.RIGHT_UP);
			DirChange(area, Enemy.Direction.LEFT_DOWN, Enemy.Direction.RIGHT_DOWN);
		}
		private void _on_BorderNorth_area_entered(object area) {
			DirChange(area, Enemy.Direction.LEFT_UP, Enemy.Direction.LEFT_DOWN);
			DirChange(area, Enemy.Direction.RIGHT_UP, Enemy.Direction.RIGHT_DOWN);
		}
		private void _on_BorderEast_area_entered(object area) {
			DirChange(area, Enemy.Direction.RIGHT_UP, Enemy.Direction.LEFT_UP);
			DirChange(area, Enemy.Direction.RIGHT_DOWN, Enemy.Direction.LEFT_DOWN);
		}
		private void _on_BorderSouth_area_entered(object area) {
			DirChange(area, Enemy.Direction.LEFT_DOWN, Enemy.Direction.LEFT_UP);
			DirChange(area, Enemy.Direction.RIGHT_DOWN, Enemy.Direction.RIGHT_UP);
		}
		private void DirChange (object area, Enemy.Direction dir1, Enemy.Direction dir2) {
			if(!GameGlobal.gameOver) {
				if(area.GetType() == typeof(Enemy)) {
					Enemy enemy = (Enemy) area;
					if(enemy.direction == dir1) {
						enemy.direction = dir2;
					} else if (enemy.direction == dir2) {
						enemy.direction = dir1;
					}
				}
			}
		}
	}
}
