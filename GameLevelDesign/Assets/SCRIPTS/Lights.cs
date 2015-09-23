using UnityEngine;
using System.Collections;

public class Lights : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Color darkColor = Color.black;
		for(int i = 0; i < transform.childCount - 1; i++){
			if(Random.Range(0,4) == 0){
				transform.GetChild(i).renderer.material.color = darkColor;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
