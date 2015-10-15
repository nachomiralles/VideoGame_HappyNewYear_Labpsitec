using UnityEngine;
using System.Collections;

public class GUI_FinFracaso : MonoBehaviour {
	public Texture2D fondo;
	private string cadena;
	public GUISkin skin;
	// Use this for initialization
	void Start () {
		cadena = "Vaya, no lo has conseguido. ¿Quieres volver a intentarlo?"; 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.skin = skin;
		GUI.DrawTexture(new Rect(0,0,Screen.width, Screen.height),fondo);
		GUI.TextArea(new Rect(Screen.width/2, Screen.height/12, Screen.width/2-Screen.width/20, Screen.height/3), cadena);
		if(GUI.Button(new Rect(Screen.width/2+Screen.width/12, Screen.height/6 + Screen.height/4, Screen.width/6, Screen.height/12),"Volver a Jugar"))
			Application.LoadLevel("Inicio");
	}
}
