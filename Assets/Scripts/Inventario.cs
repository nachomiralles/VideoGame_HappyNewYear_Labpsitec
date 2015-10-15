using UnityEngine;
using System.Collections;

public class Inventario : MonoBehaviour {

	// Use this for initialization
	private string cadena;
	private string cadenaFinal;
	private int cambios;


	void Start () {
		cadena		=   "_____ ___ ____";
		cadenaFinal	=	"FELIZ AÑO 2014";
		cambios = 0;
	}

	public void agregar(string l){
		int posicion = cadenaFinal.IndexOf(l);
		cadena = cadena.Remove(posicion,1);
		cadena = cadena.Insert(posicion, l);
		cambios+=1;
		if (cambios==12){
			Application.LoadLevel("EscenaFinExito");
		}
	}

	public string getCadena(){
		return cadena;
	}
	                
}
