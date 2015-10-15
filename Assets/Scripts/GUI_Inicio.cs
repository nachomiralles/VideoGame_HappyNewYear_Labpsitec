using UnityEngine;
using System.Collections;

public class GUI_Inicio : MonoBehaviour {
	public Texture2D fondo;
	private string cadena;
	public GUISkin skin;
	// Use this for initialization
	void Start () {
		cadena = "¡Ayuda! Cristina y Rosa han perdido las felicitaciones por el laboratorio y necesitan ayuda para encontrarlas. ¡Pero cuidado con el monstruo y el tiempo!. Usa las FLECHAS o las teclas W-A-S-D para moverte."; 
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.skin = skin;
		GUI.DrawTexture(new Rect(0,0,Screen.width, Screen.height),fondo);
		GUI.TextArea(new Rect(Screen.width/2, Screen.height/12, Screen.width/2-Screen.width/20, Screen.height/3), cadena);
		if(GUI.Button(new Rect(Screen.width/2+Screen.width/12, Screen.height/6 + Screen.height/4, Screen.width/6, Screen.height/12),"CRISTINA"))
			Application.LoadLevel("EscenaCristina");
		if(GUI.Button(new Rect(Screen.width/2+Screen.width/12 + Screen.width/5, Screen.height/6 + Screen.height/4, Screen.width/6, Screen.height/12),"ROSA"))
			Application.LoadLevel("EscenaRosa");
	}
}
