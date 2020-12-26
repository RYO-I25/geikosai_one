using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// bullet prefab
	public GameObject bullet;
	public GameObject white;
	public GameObject whitepanal;

	// 弾丸発射点
	public Transform muzzle;

	// 弾丸の速度
	public float speed = 1000;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		// z キーが押された時
		if(Input.GetButton ("Fire1")){

			GameObject[] panal = GameObject.FindGameObjectsWithTag("panal");

			foreach(GameObject p in panal) {
				p.SetActive(false);
			}


			// 弾丸の複製
			GameObject bullets = GameObject.Instantiate(bullet)as GameObject;

			Vector2 force;
			force = this.gameObject.transform.up * speed;
			// Rigidbodyに力を加えて発射
			bullets.GetComponent<Rigidbody2D>().AddForce (force);
			// 弾丸の位置を調整
			bullets.transform.position = muzzle.position + new Vector3(0,2,0);

			gameObject.SetActive (false);
			white.SetActive (true);
			whitepanal.SetActive (true);
		}
	}
}