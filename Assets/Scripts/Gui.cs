using UnityEngine;
using System.Collections;

public class Gui : MonoBehaviour {

	Inventario inventario;
	private float tiempoFin;
	private string cadenaTiempo;
	private int tiempoRestante;


	public GUISkin skin;
	void Start () {
		inventario =(Inventario) GameObject.FindWithTag("Player").GetComponent(typeof(Inventario));
		tiempoFin = Time.time + 120;
		cadenaTiempo = "100";
	}
	
	// Update is called once per frame
	void Update () {
		tiempoRestante = (int) (tiempoFin - Time.time);
		cadenaTiempo = tiempoRestante.ToString();
		if(tiempoRestante<0)
			Application.LoadLevel("EscenaFinFracaso");
	
	}

	void OnGUI(){
		GUI.skin = skin;
		GUI.Label(new Rect(Screen.width/12, Screen.height/20, Screen.width/2, Screen.height/4), inventario.getCadena());
		GUI.Label(new Rect(Screen.width - Screen.width/10, Screen.height/20, Screen.width/2, Screen.height/4), cadenaTiempo);
	}

}