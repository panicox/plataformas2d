using UnityEngine;
using System.Collections;

public class trigger_rana : MonoBehaviour {
	Animator animacion;
	// Use this for initialization
	void Start () {
		animacion = GetComponent<Animator> ();
	}

	void OnTriggerEnter2D (Collider2D objeto) {
	if (objeto.tag == "Player") {
		animacion.SetTrigger ("Salto");
		
		}
	}
}