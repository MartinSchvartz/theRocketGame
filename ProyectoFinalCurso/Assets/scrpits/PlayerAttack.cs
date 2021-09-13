using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    // Use this for initialization
    public Animator AtacarAnim;
  
    bool ClickIzq;

    void Start () {
     
  

}

// Update is called once per frame
void Update()
    {
       

        ClickIzq = Input.GetMouseButtonDown(0);
        if (ClickIzq == true)
        {
      

            AtacarAnim.SetTrigger("Attack");
           
        }
        /*bool PresionadoClickIzq;
        PresionadoClickIzq = Input.GetMouseButtonDown(0);
        if (PresionadoClickIzq==true)
        {
            AtacarAnim.SetTrigger("Atacar");
        }*/
    }
}
