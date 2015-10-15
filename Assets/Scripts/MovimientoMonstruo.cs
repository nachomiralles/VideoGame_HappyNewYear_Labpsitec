using UnityEngine;
using System.Collections;

public class MovimientoMonstruo : MonoBehaviour {

	private Transform objeto;
	private float tiempoDesdeCambio;
	public float tiempoCambio, velocidad;
	private int direccion;
	public int tipoMovimiento;
	private Vector3 vectorMovimiento;

	void Start () {
		objeto= transform;
		tiempoDesdeCambio=Time.time;
		direccion=1;
		if(tipoMovimiento==1)
			vectorMovimiento=objeto.forward;
		else
			vectorMovimiento=objeto.right;

	}
	
	void Update () {
		if(Time.time-tiempoDesdeCambio<tiempoCambio)
			moverMonstruo(direccion);
		else{
			cambiarDireccion(direccion);
			moverMonstruo(direccion);
			tiempoDesdeCambio=Time.time;
		}

	}

	void moverMonstruo(int direccion){
		switch(direccion){
		case 1:
			objeto.Translate(vectorMovimiento * velocidad * Time.deltaTime);
			break;
		case 2:
			objeto.Translate(vectorMovimiento * velocidad * -1 * Time.deltaTime);
			break;
		}
	}

	void cambiarDireccion(int d){
		if(d==1)
			this.direccion=2;
		else
			this.direccion=1;
	}
}
