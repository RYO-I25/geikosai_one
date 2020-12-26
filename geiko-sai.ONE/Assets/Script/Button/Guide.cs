using UnityEngine;
using System.Collections;

public class Guide : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("a");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void ButtonPush(){

		Application.LoadLevel ("Guide");

	}
}
