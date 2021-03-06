﻿using UnityEngine;
using System.Collections;


public class player1_script : MonoBehaviour {
	public float velocidad = 5f;
	public float salto = 10f;
	public float power = 1f;
	public bool tocando_suelo = false;
	public GameObject particulas_muerte;

	public AudioClip sonido_salto;
	public AudioClip sonido_herir;
	public AudioClip sonido_moneda;

	private Animator animator;
	private Rigidbody2D rb;
	private GameControlScript gcs;
	private AudioSource audio;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D> ();
		gcs = GameObject.Find ("GameControl").GetComponent<GameControlScript> (); 
		audio = GetComponent <AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		animator.SetFloat ("velocidad_animator", Mathf.Abs (rb.velocity.x));
		if (Input.GetKey ("right")) {
			rb.velocity = new Vector2 (velocidad * power, rb.velocity.y);
			transform.localScale = new Vector3 (1, 1, 1);
		}
		if (Input.GetKeyUp ("right")) {
			rb.velocity = new Vector2 (0, rb.velocity.y);
		}
		if (Input.GetKey ("left")) {
			rb.velocity = new Vector2 (-velocidad * power, rb.velocity.y);
			transform.localScale = new Vector3 (-1, 1, 1);
		}
		if (Input.GetKeyUp ("left")) {
			rb.velocity = new Vector2 (0, rb.velocity.y);
		}
		if (Input.GetKey (KeyCode.Space) && tocando_suelo) {
			rb.AddForce (Vector2.up * salto);
			animator.SetBool ("saltando", true);
			audio.PlayOneShot (sonido_salto,0.5f); //0.5f reproduce el sonido a la mitad de su volumen

		}
	}

	void OnTriggerStay2D(Collider2D objeto){
		if (objeto.tag == "suelo"){
			tocando_suelo = true;
		}
	}

	void OnTriggerExit2D(Collider2D objeto){
		if (objeto.tag == "suelo") {
			tocando_suelo = false;

			}
		}

	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "suelo") {
			tocando_suelo = true;
			animator.SetBool ("saltando", false);

		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "muerte"){
			Invoke ("muerte", 1);
			// InvokeRepeating invoca enemigos cada cierto tiempo
			audio.PlayOneShot (sonido_herir);
			Instantiate(particulas_muerte, transform.position, transform.rotation);
		}
		if (col.gameObject.tag == "moneda") {
			audio.PlayOneShot (sonido_moneda);
		}
	}
	void muerte (){
		gcs.respawn ();	
	}
}