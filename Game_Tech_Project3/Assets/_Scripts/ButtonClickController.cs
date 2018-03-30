using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClickController : MonoBehaviour {
	public void changeScene(){
		if(this.GetComponentInChildren<Text>().text=="Next Scene"){
			SceneManager.LoadScene ("__Scene2");
			int a = PlayerPrefs.GetInt ("Times");
			PlayerPrefs.SetInt("Times",++a);
		}else if(this.GetComponentInChildren<Text>().text=="Return"){
			SceneManager.LoadScene ("__Scene1");
			int a = PlayerPrefs.GetInt ("Times");
			PlayerPrefs.SetInt("Times",++a);
		}
	}
}
