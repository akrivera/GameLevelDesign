using UnityEngine;
using System.Collections;

public class TeleTarget : MonoBehaviour {
	bool set;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonUp(0)){
			Destroy(gameObject);
		}

		if(set){
			if(Input.GetMouseButtonUp(1)){
				GameObject.FindGameObjectWithTag("Player").transform.position = transform.position + Vector3.up * 3;
				Destroy(gameObject);
			}	
		}
	}

	void OnTriggerEnter(Collider hit){
		if(hit.tag == "Ground"){
			rigidbody.isKinematic = true;
			rigidbody.useGravity = false;
			set = true;
		}
	}
}
