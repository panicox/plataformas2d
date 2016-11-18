using UnityEngine;
using System.Collections;

public class freno : MonoBehaviour {
	// Definimos una variable para acceder al Rigidbody2D
	Rigidbody2D rb_rueda;
	void Start () {
		// Cargamos la información del componente en la variable
		rb_rueda = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		//Al pulsar la tecla B bloqueamos la rueda
		if(Input.GetKeyDown(KeyCode.B)){
			rb_rueda.freezeRotation = true;
		}
		//Al soltar la tecla B desbloqueamos la rueda
		if(Input.GetKeyUp(KeyCode.B)){
			rb_rueda.freezeRotation = false;
		}

	}
}
