using UnityEngine;

public class PlayerSelection : MonoBehaviour
{

	public GameObject Prefab;
	public GameObject Parent;
	public void PlayerList()
	{
		enemySpawn();
		//StartCoroutine(enemyTimeSpawn());
	}

	
	public void enemySpawn()
	{
		for (int i = 1; i <= 8; i++)
		{
			//yield return new WaitForSeconds(0f);
			GameObject List = Instantiate(Prefab) as GameObject;
			List.transform.parent = Parent.transform;
			List.transform.localScale = new Vector3(1, 1, 1);
			List.GetComponent<PlyerSelecText>().ShowList($"name{i}", i + 1, i * 10);
		}
	}
	//IEnumerator enemyTimeSpawn()
	//{
	//
	//}

}
