using UnityEngine;
using System.Collections;

public class MovimientoPersonaje : MonoBehaviour {
	private Vector3 direccion;
	private float magnitud;
	private int velocidad;
	// Use this for initialization
	void Start () {
		velocidad = 3;
	}
	
	// Update is called once per frame
	void Update () {
		direccion = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

		if (direccion != Vector3.zero) {
			magnitud = direccion.magnitude;
			direccion =  direccion/magnitud;

			magnitud = Mathf.Min(1, magnitud);

			direccion = direccion * magnitud;


		}

		transform.Translate(direccion * velocidad/10);
	}
}
