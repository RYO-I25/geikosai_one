using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {

	public float life_time = 4.0f;
	float time = 0f;

	// Use this for initialization
	void Start () {
		time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		print (time);

		GameObject[] target = GameObject.FindGameObjectsWithTag("Target");
		if(time>life_time){
		foreach(GameObject tg in target) {
			Destroy(tg);
	}
}
}


}