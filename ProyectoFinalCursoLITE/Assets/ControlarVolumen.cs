using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlarVolumen : MonoBehaviour {
    public static AudioClip Fondo;
    static AudioSource AudioSrc;
    public float Volumen=0f;
	// Use this for initialization
	void Start () {
        Fondo = Resources.Load<AudioClip>("Fondo");
        AudioSrc = GetComponent<AudioSource>();
        AudioSrc.volume = Volumen;
        AudioSrc.Play();
    }

    // Update is called once per frame
    void Update () {
      
	}
}
