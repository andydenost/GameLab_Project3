using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldActiveState : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 1;i<3;i++){
			for(int j = 1;j<5;j++){
				if(this.name == "Gold"+i+j){
					if(StaticData.goldState[i-1,j-1]==false){
						this.gameObject.SetActive (false);
					}
				}
			}
		}
	}
}
