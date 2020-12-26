using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class Resultscore : MonoBehaviour {

	 int resultScore = Score.score;
	public Text resultscoreText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {resultscoreText.text =  resultScore.ToString();
	
	}
}
