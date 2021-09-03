using UnityEngine;

public class CamEnableDisable : MonoBehaviour
{
	public Camera cam1;
	public Camera cam2;
	private void Start()
	{
		cam1.enabled = false;
		cam2.enabled = true;
	}
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.LeftShift))
		{
			cam1.enabled = !cam1.enabled;
			cam2.enabled = !cam2.enabled;
		}
		if (Input.GetKeyUp(KeyCode.LeftShift))
		{
			cam1.enabled = !cam1.enabled;
			cam2.enabled = !cam2.enabled;
		}
	}
}
