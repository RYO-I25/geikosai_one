using UnityEngine;
using System.Collections;

public class chara : MonoBehaviour {
	public GameObject[] player;
	public Transform ps1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int count = GameObject.FindGameObjectsWithTag ("p").Length;
	
		if (count < 1){Instantiate(player[Random.Range (0, player.Length)],ps1.position,ps1.rotation);
		}

	}
}
