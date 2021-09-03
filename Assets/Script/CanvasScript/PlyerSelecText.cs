using UnityEngine;
using UnityEngine.UI;

public class PlyerSelecText : MonoBehaviour
{
	public Text pName;
	public Text pLavel;
	public Text pBScore;

	public void ShowList(string p, int l, int s)
	{
		pName.text = p;
		pLavel.text = $"{l}";
		pBScore.text = $"{s}";
	}
}
