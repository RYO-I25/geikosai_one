using UnityEngine;
using System.Collections;

public class itemspawn1 : MonoBehaviour {

	public GameObject []item;
	public Transform ps1;
	//	public Transform ps2;
	//	public Transform ps3;
	public float []waitingTime;


	void Start() { InvokeRepeating("Create", waitingTime[Random.Range (0,waitingTime .Length)], waitingTime[Random.Range (0,waitingTime .Length)]);

	}

	void Update(){
	}


	void Create(){
		float x = -15.9f;
		float y = 6.3f;
		//		for (int y = 0; y < 5; y++) {
		//			for (int x = 0; x < 5; x++) {

		//		Instantiate(item[Random.Range (0, item.Length)], ps2.position,transform.rotation);
		Instantiate(item[Random.Range (0, item.Length)],ps1.position,transform.rotation);
		//		Instantiate(item[Random.Range (0, item.Length)], ps3.position,transform.rotation);
	}
}