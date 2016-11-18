using UnityEngine;
using System.Collections;

public class coche2 : MonoBehaviour {
	// Definimos una variable para meter dentro el componente WheelJoint2D
	WheelJoint2D union_rueda; 
	JointMotor2D motor;

	void Start () {
		//Metemos la información del componente WheelJoint2D en la variable
		union_rueda = GetComponent<WheelJoint2D> ();
		motor = union_rueda.motor; 

	}

	void Update () {
		
		// Vemos si pulsamos la tecla espacio
		if (Input.GetKey (KeyCode.Space)) {
			// Cambiamos el valor de la variable useMotor al contrario de su valor
			union_rueda.useMotor = true;
			motor.motorSpeed = union_rueda.motor.motorSpeed - 5f;
			union_rueda.motor = motor;
		} else {
			motor.motorSpeed = -100f;
			union_rueda.motor = motor;
			union_rueda.useMotor = false;
		}

	}
}
