using UnityEngine;

namespace MazeGame
{
	public class RotateMaze : MonoBehaviour
	{
		[SerializeField]
		GameObject Maze;
		void Start() { Input.compensateSensors = true; Input.gyro.enabled = true; }
		void Update()
		{
			if (Input.GetKey(KeyCode.A)) transform.Rotate(0, 0, 0.1f);
			if (Input.GetKey(KeyCode.D)) transform.Rotate(0, 0, -0.1f);
			if (Input.GetKey(KeyCode.W)) Maze.transform.Rotate(0.1f, 0, 0);
			if (Input.GetKey(KeyCode.S)) Maze.transform.Rotate(-0.1f, 0, 0);
			transform.Rotate(-Input.gyro.rotationRateUnbiased.x, 0, 0);
			Maze.transform.Rotate(0, Input.gyro.rotationRateUnbiased.y, 0);
		}
	}
}
