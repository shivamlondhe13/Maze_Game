using UnityEngine;

public class CrasherMovement : MonoBehaviour
{
	public float movementSpeed=0.7f;
	void Update()=>transform.position += new Vector3(0, movementSpeed, 0)*Time.deltaTime;
	public void OnTriggerExit(Collider other){
		if (other.gameObject.name == "Roof" )
		{
			if(movementSpeed == -0.7f) movementSpeed = 0.7f;
			else movementSpeed = -0.7f;
		}
	}
}
