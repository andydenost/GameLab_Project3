using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IDcontrol : MonoBehaviour {

	//private GameObject gb;
	private string s;
	// Use this for initialization
	void Start () {
		//gb = GameObject.Find ("playerID");
	}
	
	// Update is called once per frame
	void Update () {
		s = Singleton.instance.ID;
		this.GetComponent<Text> ().text = "Player ID: " + s;
		//this.GetComponent<Text>().text = "Gold number you got: "+StaticData.goldNum;

	}
}
