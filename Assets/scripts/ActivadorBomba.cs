using UnityEngine;
using System.Collections;

public class ActivadorBomba : MonoBehaviour {

	public Rigidbody2D rb_bomba;

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D objeto) {
		if(objeto.tag == "Player"){
			rb_bomba.isKinematic = false;
		}
				
	}
}