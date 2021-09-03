using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MazeGame
{
	public class PlayerCollisionDetection : MonoBehaviour
	{
		int sceneno;
		public int Scoare { get; set; }
		[SerializeField]
		Text ScoreText;
		void Start()
		{
			Scoare = 0;
			sceneno = SceneManager.GetActiveScene().buildIndex;
		}
		public void OnTriggerEnter(Collider other)
		{
			switch (other.gameObject.tag)
			{
				case "Respawn":
					SceneManager.LoadScene(sceneno);
					break;
				case "Portal1":
					Scoare++;
					ScoreText.text = Scoare.ToString();
					Destroy(other.gameObject);
					break;
				case "Portal2":
					Scoare++;
					ScoreText.text = Scoare.ToString();
					Destroy(other.gameObject);
					break;
				case "Portal3":
					Scoare++;
					ScoreText.text = Scoare.ToString();
					Destroy(other.gameObject);
					break;
				case "Portal4":
					Scoare++;
					ScoreText.text = Scoare.ToString();
					Destroy(other.gameObject);
					break;
				case "Portal5":
					Scoare++;
					ScoreText.text = Scoare.ToString();
					Destroy(other.gameObject);
					break;
				case "Portal6":
					ScoreText.text = Scoare.ToString();
					Destroy(other.gameObject);
					break;
				case "Portal7":
					Scoare++;
					Destroy(other.gameObject);
					break;
				case "Portal8":
					Scoare++;
					ScoreText.text = Scoare.ToString();
					Destroy(other.gameObject);
					break;
				case "Portal9":
					Scoare++;
					ScoreText.text = Scoare.ToString();
					Destroy(other.gameObject);
					break;
				case "Portal10":
					Scoare++;
					ScoreText.text = Scoare.ToString();
					Destroy(other.gameObject);
					break;
				case "Portal11":
					Scoare++;
					ScoreText.text = Scoare.ToString();
					Destroy(other.gameObject);
					break;
				case "WinLevel3":
					if (Scoare == 11) { }
					else { Debug.Log("Collect 11 Coines"); }
					break;
				default:
					break;
			}
		}
		public void OnCollisionEnter(Collision collision)
		{
			switch (collision.gameObject.tag)
			{
				case "Opsticals":
					SceneManager.LoadScene(sceneno);
					break;
				default:
					break;
			}
		}
	}
}
