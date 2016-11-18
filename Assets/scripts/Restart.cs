using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; //IMPORTANTE PARA PODER MODIFICIAR ESCENAS

public class Restart : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Reiniciar ();
		}
	}

	public void Reiniciar(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
		Debug.Log ("Reiniciamos el nivel actual");
	}

	public void CargarNivel(int nivel){ //int es para numeros enteros
		SceneManager.LoadScene (nivel);
	}
}