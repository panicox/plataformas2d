using UnityEngine;
using System.Collections;

public class enlazar_player : MonoBehaviour { 

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			col.gameObject.transform.parent = transform;
		}
	}
	void OnCollisionExit2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			col.gameObject.transform.parent = null;	//null = vacío
		}
	}
}
