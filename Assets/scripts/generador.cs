using UnityEngine;
using System.Collections;

public class generador : MonoBehaviour {

	public GameObject[] monedas;
	private Transform pos_salida;
	private GameObject monedaNueva; //si el objeto "is trigger"
	private GameObject moneda_nueva;
	private int numero_moneda = 0; //crea un numero entero que nos indica el numero de monedas que tiene el objeto
	void Start(){
		pos_salida = transform.Find ("salida").transform; //transform.find = buscar dentro del hijo; GameObject.Find = buscar dentro de la escena
		Debug.Log ("Cantidad de monedas: " + monedas.Length);
	}
	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Player" && moneda_nueva == null) {
			numero_moneda = Random.Range (0, monedas.Length-1); //muestra en consola el numero de monedas -1 (porque empezamos a contar desde el 0, no desde el 1)
			moneda_nueva = (GameObject)Instantiate (monedas[numero_moneda],
				pos_salida.position,
					transform.rotation);
		}
	}
	void OnTriggerEnter2D(Collider2D objeto){
		if(objeto.tag == "Player" && monedaNueva == null){
			monedaNueva = (GameObject)Instantiate (monedas[numero_moneda], transform.position, transform.rotation);
		}
	}
}
