using UnityEngine;
using System.Collections;

public class MovimientoRecto : MonoBehaviour {
	public GameObject plataforma;
	public Transform inicio;
	public Transform fin;
	public float velocidad = 5f;
	private Vector3 destino;

	// Use this for initialization
	void Start () {
		destino = fin.position;
	}
	
	// Update is called once per frame
	void Update () {
		plataforma.transform.position = 
			Vector3.MoveTowards (plataforma.transform.position, //MoveTowards = mover entre dos puntos
			destino,
			velocidad * Time.deltaTime); //Time.deltatime = dice el tiempo entre frame y frame de cada ordenador

		if (plataforma.transform.position == fin.position) {
			destino = inicio.position;
		}
		if (plataforma.transform.position == inicio.position) {
			destino = fin.position;
		}
	}
}