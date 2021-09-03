using UnityEngine;
namespace MazeGame
{
	public class CameraBounce : MonoBehaviour
	{
		private new Animator animation;
		private void Start()
		{
			animation = this.GetComponent<Animator>();
			animation.enabled = false;
		}
		void Update()
		{
			if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)) animation.enabled = true;
			else animation.enabled = false;
		}
	}
}
