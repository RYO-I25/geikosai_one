using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text scoreText; //Text用変数
//	public Text highScoreText;
	public Text timeText;
	public static  int score = 0;
//	private int highScore;
	public float time;
	void Start (){
		score = 0;
		scoreText.text = "Score: 0"; 

	}

void Update ()
{
		if( time > 0 ){
			time -= Time.deltaTime;
		}

		if( time <= 0 ){
			time = 0;
			Application.LoadLevel("Result");
		}

	// スコア・ハイスコアを表示する
//		if (highScore < score) {
//			highScore = score;
//		}

		// スコア・ハイスコアを表示する
		scoreText.text = "POINT : " + score.ToString ();
//		highScoreText.text = "HighScore : " + highScore.ToString ();
		timeText.text = "TIME : "+ time.ToString("N0") ;
	}




	public void AddPoint ( int point)
	{
		score = score + point;
	}
}