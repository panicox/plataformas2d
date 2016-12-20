using UnityEngine;
using System.Collections;

public class autoDestruccionParticulas : MonoBehaviour {

	ParticleSystem sp;
	// Use this for initialization
	void Start () {
		sp = GetComponent <ParticleSystem> ();

		Destroy (gameObject, sp.duration);
	}
}