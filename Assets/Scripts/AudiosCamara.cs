using UnityEngine;
using System.Collections;

public class AudiosCamara : MonoBehaviour {

	private AudioSource audioCogerLetra;

	void Start () {
		audioCogerLetra = (AudioSource) GetComponent(typeof(AudioSource));
	}
	
	public void letraCogida(){
		audioCogerLetra.Play();
	}

}
