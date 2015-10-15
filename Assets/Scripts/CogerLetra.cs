using UnityEngine;
using System.Collections;

public class CogerLetra : MonoBehaviour {

	public string letra;
	private AudiosCamara sonido;
	// Use this for initialization
	void Start () {
		sonido = (AudiosCamara) GameObject.FindWithTag("MainCamera").GetComponent(typeof(AudiosCamara));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other){
		sonido.letraCogida();
		Inventario inv;
		inv = (Inventario) other.GetComponent(typeof(Inventario));
		inv.agregar(letra);
		Destroy (this.gameObject);

	}
}
