using UnityEngine;
using UnityEngine.SceneManagement;

public class FristPage : MonoBehaviour
{
	private void Start()
	{
		SceneManager.UnloadSceneAsync(1);
		SceneManager.UnloadSceneAsync(2);
		SceneManager.UnloadSceneAsync(3);
	}
	public void Update()
	{
		if (Input.GetKey(KeyCode.Space))
		{
			StartGame();
		}
		if (Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
	public void StartGame()
	{
		SceneManager.LoadScene(1);
		SceneManager.UnloadSceneAsync(0);
	}
}
