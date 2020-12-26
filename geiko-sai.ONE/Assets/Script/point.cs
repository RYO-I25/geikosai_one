using UnityEngine;
using System.Collections;

public class point : MonoBehaviour {
	public  int count = 100;
//	public AudioClip audioClip;
//	AudioSource audioSource;
	public GameObject SE;

//	private GameObject target;
//	private Vector2 d;
	// Use this for initialization
	void Start () {
//		audioSource = gameObject.GetComponent<AudioSource>();
//		audioSource.clip = audioClip;
//		target = GameObject.Find("的R");
	}
	
	// Update is called once per frame
	void Update () {
//		GameObject[] target = GameObject.FindGameObjectsWithTag("Target");
//		d = target.transform.position.y - transform.position.y;

	}


	void OnTriggerEnter2D (Collider2D hit)
	{
		if (hit.CompareTag ("Target")) {
			
//			audioSource.Play();
//			SE.SetActive (true);
			// このコンポーネントを持つGameObjectを破棄する
			Destroy(gameObject);
//			string layerName = LayerMask.LayerToName (gameObject.layer);
//			//レイヤー名がBullet(Player)以外の時は何も行わない
//			if(layerName != "R")return;
//
				FindObjectOfType<Score> ().AddPoint (count);
			Instantiate(SE,transform.position,transform.rotation);
			
		}
}
}