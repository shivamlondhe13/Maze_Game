using UnityEngine;

public class MainMenu : MonoBehaviour
{
	[SerializeField]
	GameObject mainMenu;
	[SerializeField]
	GameObject newGamePage;
	[SerializeField]
	GameObject continuePage;
	private void Start()
	{
		BackPage();
	}

	public void BackPage()
	{
		mainMenu.active = true;
		newGamePage.active = false;
		continuePage.active = false;
	}

	[System.Obsolete]
	public void NewGame()
	{
		newGamePage.active = true;
		mainMenu.active = false;
	}


	public void Continue()
	{
		DBConnection DB = new DBConnection();
		DB.dataConnect();
		continuePage.active = true;
		mainMenu.active = false;
	}

	[System.Obsolete]
	public void Setting()
	{
		mainMenu.active = false;
	}

	[System.Obsolete]
	public void Level()
	{
		mainMenu.active = false;
	}
}
