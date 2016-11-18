using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class carro : MonoBehaviour {
	public DistanceJoint2D conector;
	public Text texto;
	bool coche_cerca = false;
		
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.V) && coche_cerca) {
			conector.enabled = !conector.enabled;
			if (conector.enabled) {
				texto.text = "V to desconect";
			}else{
				texto.text = "V to conect";
			}
		}
	}

	void OnTriggerStay2D(Collider2D objeto){
		if(objeto.tag == "Player"){
			coche_cerca = true;
			texto.enabled = true;
		}

	}

	void OnTriggerExit2D(Collider2D objeto){
		if(objeto.tag == "Player"){
			coche_cerca = false;
			texto.enabled = false;
		}

	}
}
