using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scomparsa : MonoBehaviour
{

    //int punti = 0;


    private void OnTriggerEnter2D(Collider2D collision){ 
        if (collision.name.Contains("Ostacoli")) {
            this.gameObject.SetActive(false);
        }
    }
}