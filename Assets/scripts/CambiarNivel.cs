using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CambiarNivel : MonoBehaviour {


	void OnTriggerEnter2D (Collider2D objeto){
		if(objeto.tag == "Player"){
			SceneManager.LoadScene ("nivel2");
		}
	}

}
