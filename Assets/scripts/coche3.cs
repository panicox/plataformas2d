using UnityEngine;
using System.Collections;
using UnityEngine.UI; //IMPORTANTE PARA USAR EL SCRIPT DE USUARIO

public class coche3 : MonoBehaviour {
	// Definimos una variable para meter dentro el componente WheelJoint2D
	WheelJoint2D union_rueda; 
	JointMotor2D motor;
	public float aceleracion = 15f;
	float velocidad = 0f;
	public Text velocimetro;

	void Start () {
		//Metemos la información del componente WheelJoint2D en la variable
		union_rueda = GetComponent<WheelJoint2D> ();
		motor = union_rueda.motor; 

	}

	void Update () {

		velocidad = GetComponent<Rigidbody2D> ().velocity.magnitude;
		velocimetro.text = "" + Mathf.Round (velocidad * 5);
		
		// Vemos si pulsamos la tecla espac

		if (Input.GetKey (KeyCode.Space)) {
			// Cambiamos el valor de la variable useMotor al contrario de su valor
			union_rueda.useMotor = true;
			motor.motorSpeed = union_rueda.motor.motorSpeed - aceleracion;
			union_rueda.motor = motor;
		} 
		if (Input.GetKeyUp (KeyCode.Space)) {
			motor.motorSpeed = 0f;
			union_rueda.motor = motor;
			union_rueda.useMotor = false;
		}

		if (Input.GetKey (KeyCode.Z)) {
			// Cambiamos el valor de la variable useMotor al contrario de su valor
			union_rueda.useMotor = true;
			motor.motorSpeed = union_rueda.motor.motorSpeed + aceleracion;
			union_rueda.motor = motor;
		} 
		if (Input.GetKeyUp (KeyCode.Z)) {
			motor.motorSpeed = 0f;
			union_rueda.motor = motor;
			union_rueda.useMotor = false;
		}

		if (Input.GetKey (KeyCode.B)) {
			motor.motorSpeed = 0f;
			union_rueda.motor = motor;
			union_rueda.useMotor = false;
		}

	}
}
