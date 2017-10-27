using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	public  UnityEngine.UI.Text scoreLabel;
	public GameObject winnerLabelObject;

	public void Update ()
	{
		int count = GameObject.FindGameObjectsWithTag ("Item").Length;
		scoreLabel.text = "残りCapsuel：" + count.ToString ();

		if (count == 0) {
			// クリア時の処理
			winnerLabelObject.SetActive (true);
		}
	}
}