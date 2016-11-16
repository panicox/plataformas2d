using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {
	private GameControlScript gcs;  //crea una variable privada que llama al script "GameControlScript"
	public Sprite banderaActivada;  //crea una variable que cambia el sprite
	private bool activada = false;	//crea una variable privada de tipo boolidiano (true / false) para activar el checkpoint al pasar


	void Start () {
		gcs = GameObject.Find ("GameControl").GetComponent<GameControlScript> ();
	}

	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "Player" && !activada){
			GetComponent<SpriteRenderer> ().sprite = banderaActivada;
			gcs.checkpoint (transform.position);
			activada = true;
		}
	}
}
	