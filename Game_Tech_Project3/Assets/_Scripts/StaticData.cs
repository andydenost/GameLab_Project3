using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticData {
	public static int goldNum;
	public static bool[,] goldState = new bool[2,4];
	static StaticData(){
		goldNum = 0;
		for(int i = 0;i<2;i++) {
			for(int j = 0;j<4;j++){
				goldState [i, j] = true;
			}
		}
		Debug.Log ("aaaa");
	}
}
