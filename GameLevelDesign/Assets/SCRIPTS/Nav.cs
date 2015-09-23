using UnityEngine;
using System.Collections;

public class Nav : MonoBehaviour {
	NavMeshAgent nav;
	Transform target;
	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent> ();
		target = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		nav.destination = target.position;
	}
}
