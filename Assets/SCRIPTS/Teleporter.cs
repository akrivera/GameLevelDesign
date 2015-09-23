using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {

	public GameObject proj;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonUp(0)){
			GameObject clone = Instantiate (proj,Camera.main.transform.position,transform.rotation) as GameObject;
			clone.rigidbody.AddForce(Camera.main.transform.forward * 10000, ForceMode.Impulse);
				
		}
	}
}
