using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisione : MonoBehaviour
{
    private void OnTriggerEnter2d(Collider2d collision)
    {
    print("sei scarso");
        this.gameObject.SetActive(false);
    

    }

}
