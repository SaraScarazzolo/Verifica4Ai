using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisione : MonoBehaviour
{

    
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.name.Contains("Blocks")) {
            this.gameObject.SetActive(false);
        }

    }
}
