using UnityEngine;
using System.Collections;

public class Red : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;
	public GameObject player3;
	public GameObject panal1;
	public GameObject panal2;
	public GameObject panal3;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D hit){
		if (hit.CompareTag ("red")) {
			GameObject[] panal = GameObject.FindGameObjectsWithTag("panal");

			foreach(GameObject p in panal) {
				p.SetActive(false);
				}

			gameObject.SetActive (false);
			player1.SetActive (true);
			panal1.SetActive (true);

		}

		if (hit.CompareTag ("green")) {
			GameObject[] panal = GameObject.FindGameObjectsWithTag("panal");

			foreach(GameObject p in panal) {
				p.SetActive(false);
			}
			gameObject.SetActive (false);
			player2.SetActive(true);
			panal2.SetActive (true);

		}
		if (hit.CompareTag ("blue")) {
			GameObject[] panal = GameObject.FindGameObjectsWithTag("panal");

			foreach(GameObject p in panal) {
				p.SetActive(false);
			}
			gameObject.SetActive (false);
			player3.SetActive(true);
			panal3.SetActive (true);

		}
	}

}

