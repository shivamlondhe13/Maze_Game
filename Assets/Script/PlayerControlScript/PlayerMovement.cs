using UnityEngine;

namespace MazeGame
{
	public class PlayerMovement : MonoBehaviour
	{
		[SerializeField]
		GameObject cam; //main camera
		private new Light light;//light object 
		float movespeed = 3f;
		void Start()
		{
			//cam.transform.position = transform.position; //set camera initial position.
			light = cam.GetComponent<Light>();
			light.intensity = 0;//set light initializaton value.
		}

		void Update()
		{
			//player Movement speed changer.
			if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift)) movespeed = movespeed * 2;
			if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift)) movespeed = movespeed / 2f;

			//Player Rotation.
			cam.transform.Rotate(Input.GetAxis("Mouse Y") * Time.deltaTime * -50f, 0, 0);
			transform.Rotate(0, -Input.GetAxis("Mouse X") * Time.deltaTime * -50f, 0);

			//Player Movement Inputs.
			float x = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
			float z = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;

			// Player Move.
			transform.Translate(z, 0, x);

			// Player Toarch.
			if (Input.GetKeyDown(KeyCode.Mouse1))
			{
				switch (light.intensity)
				{
					case 0:
						light.intensity = 2;
						break;
					case 2:
						light.intensity = 0;
						break;
					default: break;
				}
			}
		}
	}

}
