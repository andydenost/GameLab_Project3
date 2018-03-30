using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour{

	public static Singleton instance = null;
	public string ID = null;
	void Awake(){
		if (instance == null) {
			instance = this;
		}else if(instance!=this){
			Destroy (gameObject);
		}
		DontDestroyOnLoad (gameObject);
		init ();
	}

	void init(){
		ID = "Haoyun Li";
	}

}