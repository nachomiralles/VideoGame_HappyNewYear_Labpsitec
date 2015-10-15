using UnityEngine;
using System.Collections;

public class TocadoPorMonstruo : MonoBehaviour {

	void OnTriggerEnter (Collider other){
		Debug.Log("Entra");
		if(other.tag.Equals("Enemy"))
			Application.LoadLevel("EscenaFinFracaso");
		
	}
}
