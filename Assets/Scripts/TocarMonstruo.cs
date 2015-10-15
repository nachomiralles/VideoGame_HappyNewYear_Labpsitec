using UnityEngine;
using System.Collections;

public class TocarMonstruo : MonoBehaviour {

	void OnTriggerEnter (Collider other){
		if(other.tag.Equals("Player"))
			Application.LoadLevel("EscenaFinFracaso");
		
	}
}
