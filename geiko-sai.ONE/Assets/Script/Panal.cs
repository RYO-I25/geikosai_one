using UnityEngine;
using System.Collections;

public class Panal : MonoBehaviour {

	bool moveflg = false; // 移動中はtrue
	void Start () {
	}



	void Update () {
		// Vector3はnullが設定できないので?を付けてnull許容型にする


		Vector3? movepos = null;


		// キーを押すと現在位置(transform.position)と移動量で移動先を算出
			if (Input.GetKey (KeyCode.RightArrow)) {
				movepos = - new Vector3 (0f, 0.0f, 0.0f);
			}



			if (Input.GetKey (KeyCode.LeftArrow)) {
				movepos = new Vector3 (0f, 0.0f, 0.0f);
			}

		//		if (Input.GetKeyDown(KeyCode.UpArrow))
		//		{
		//			movepos = transform.position + new Vector3(0.0f, 0.0f, 4.0f);
		//		}
		//
		//		if (Input.GetKeyDown(KeyCode.DownArrow))
		//		{
		//			movepos = transform.position - new Vector3(0.0f, 0.0f, 4.0f);
		//		}

		// キーが押されて移動量が算出された状態
		// 且つ移動中でない場合移動
		if( movepos != null && moveflg == false)
		{

			iTween.MoveTo(gameObject,
				iTween.Hash(
					"position", movepos, // 移動先
					"time", 0.2f, // 移動にかかる秒数(調整してください)1.5fのようにfは必要ありません
					"oncomplete", "complete" // 移動が終了すると関数complete()が呼ばれる
				));
			moveflg = true;

		}

	}



	void complete()
	{
		// 移動が終了したので移動中flagをfalseにする
		moveflg = false;
	}

}
