using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MazeGame
{
	public class Win : MonoBehaviour
	{
		int sceneNo;
		int a;
		public GameObject canvas;
		public GameObject next;

		[Obsolete]
		private void Start()
		{
			a = SceneManager.sceneCountInBuildSettings;
			a -= 1;
			canvas.active = false;
			sceneNo = SceneManager.GetActiveScene().buildIndex;
		}

		[Obsolete]
		void Update()
		{
			if (Input.GetKey(KeyCode.Space)) WinGame();
			if (Input.GetKey(KeyCode.Escape)) Home();
		}

		[Obsolete]
		private void OnTriggerEnter(Collider other)
		{
			if (other.gameObject.tag == "Player") WinGame();
		}
		[Obsolete]
		public void WinGame()
		{
			canvas.active = true;
			if (a == sceneNo) next.active = false;
		}
		public void Next()
		{
			sceneNo += 1;
			SceneManager.LoadScene(sceneNo);
			sceneNo -= 1;
			SceneManager.UnloadSceneAsync(sceneNo);
		}
		public void Restart() => SceneManager.LoadScene(sceneNo);
		public void Home()
		{
			SceneManager.UnloadSceneAsync(sceneNo);
			SceneManager.LoadScene("frontPage");
		}
	}
}
