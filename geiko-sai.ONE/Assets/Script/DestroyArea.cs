using UnityEngine;
using System.Collections;

public class DestroyArea : MonoBehaviour {

	void start(){
	}

	void Update(){
	}

	void OnTriggerEnter2D (Collider2D hit)
	{if (hit.CompareTag ("Darea")) {

			Destroy (gameObject);
		}
	}
}