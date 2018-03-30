using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		speed = 3.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("w")){
			this.transform.Translate (0,0,speed*Time.deltaTime);
		}
		if(Input.GetKey("s")){
			this.transform.Translate (0,0,-speed*Time.deltaTime);
		}
		if(Input.GetKey("a")){
			this.transform.Translate (-speed*Time.deltaTime,0,0);
		}
		if(Input.GetKey("d")){
			this.transform.Translate (speed*Time.deltaTime,0,0);
		}
	}

	void OnTriggerEnter(Collider c) {
		if(c.gameObject.tag == "gold"){
			StaticData.goldNum++;
			Debug.Log (StaticData.goldNum);
			for(int i = 1;i<3;i++){
				for(int j = 1;j<5;j++){
					if(c.name == "Gold"+i+j){
						StaticData.goldState [i-1, j-1] = false;
					}
				}
			}
		}
		//Destroy (c.gameObject);
		c.gameObject.SetActive(false);
	}
}
