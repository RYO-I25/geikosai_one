using UnityEngine;
using System.Collections;

public class Cameramove : MonoBehaviour {

	public float speed = 2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.down * Time.deltaTime*speed);
	}
}
