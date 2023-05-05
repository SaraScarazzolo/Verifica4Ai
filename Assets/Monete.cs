using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monete : MonoBehaviour
{

    int monete = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Contains("Coin"))
        {
            monete++;
            collision.gameObject.SetActive(false);
            print("Ho raccolto una moneta e ne ho" + monete);
        }
    }
    



}
