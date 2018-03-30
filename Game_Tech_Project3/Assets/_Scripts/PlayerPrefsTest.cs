using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsTest{
	private int times = 0;
	PlayerPrefsTest(){
		PlayerPrefs.SetInt("Times",times);
	}
}
