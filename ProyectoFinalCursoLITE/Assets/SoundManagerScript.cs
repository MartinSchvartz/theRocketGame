using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{


    public static AudioClip CoinSound,Explosion;
    static AudioSource AudioSrc;

	// Use this for initialization
	void Start ()
    {
        CoinSound = Resources.Load < AudioClip>("Coin");
        Explosion = Resources.Load<AudioClip>("Explosion");

        AudioSrc = GetComponent<AudioSource>();

	}
	
	
    public static void PlaySound(string Clip)
    {

        if (Clip=="Coin")
        {
            AudioSrc.PlayOneShot(CoinSound);
        }
        else if (Clip=="Obstaculo")
        {
            AudioSrc.PlayOneShot(Explosion);

        }


    }


}



