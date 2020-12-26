using UnityEngine;
using System.Collections;

public class titlemove : MonoBehaviour {
    public float speed;
	public float time;


	// Use this for initialization
	void Start () {
		int count = GameObject.FindGameObjectsWithTag ("p").Length;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * Time.deltaTime*speed);

		int count = GameObject.FindGameObjectsWithTag ("p").Length;

		time -= Time.deltaTime;
		if (time <= 2) {
			
			transform.rotation = new Quaternion (180, 180, 0,0);
		}

		if (time <= 0) {
			time = 0;
			Destroy (gameObject);
		}

	}
}
