using UnityEngine;

public class moneda : MonoBehaviour {
	// función para controlar cuando un objeto entra en el trigger
	void OnTriggerEnter2D(Collider2D col){
		Debug.Log ("Alguien me ha tocado");
		Destroy (gameObject);
	}

	void OnTriggerExit2D(Collider2D col){
		Debug.Log ("Han dejado de tocarme");
	}

	void OnTriggerStay2D(Collider2D col){
		Debug.Log ("Me están tocando, me siento incómodo");
	}
}

