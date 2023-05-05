using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Nemico : MonoBehaviour
{
    public TextMeshProUGUI scrittaFinale;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
            scrittaFinale.SetText("Hai perso!");
            Application.Quit();
        }
    }
}
