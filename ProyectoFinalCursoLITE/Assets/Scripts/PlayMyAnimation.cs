using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMyAnimation : MonoBehaviour {

    [SerializeField] private Animator MyAnimationController;
    public GameObject Explosion;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Obstaculo")
        {
            
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstaculo")
        {
            Explosion.SetActive(false);
            MyAnimationController.SetBool("Explosion", false);
        }

    }
}
