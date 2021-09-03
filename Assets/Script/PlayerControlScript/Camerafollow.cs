using UnityEngine;

namespace MazeGame
{
	public class Camerafollow : MonoBehaviour//mini map camera
	{
		[SerializeField]
		GameObject player;
		Vector3 offset;
		[SerializeField]
		GameObject cam;
		new Light light;

		[System.Obsolete]
		void Start()
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
			offset = transform.position - player.transform.position;
			cam.active = false;
			light = GetComponent<Light>();
			Light_Intensity(false);
		}

		[System.Obsolete]
		void Update()
		{
			transform.position = player.transform.position + offset;
			if (Input.GetKeyDown(KeyCode.M))
			{
				Cursor.lockState = CursorLockMode.Confined;
				Cursor.visible = true;
				Light_Intensity(true);
				cam.active = true;
			}
			if (Input.GetKeyUp(KeyCode.M))
			{
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
				Light_Intensity(false);
				cam.active = false;
			}
		}
		void Light_Intensity(bool l) => light.enabled = l;

	}
}
