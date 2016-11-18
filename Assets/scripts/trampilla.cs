using UnityEngine;
using System.Collections;

public class trampilla : MonoBehaviour {
	HingeJoint2D abierto;
	void Start () { 
		abierto = GetComponent <HingeJoint2D> ();
	}
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			abierto.useMotor = true;
		}
		if (Input.GetKeyUp (KeyCode.A)) {
			abierto.useMotor = false;
		}
	}
}

	
