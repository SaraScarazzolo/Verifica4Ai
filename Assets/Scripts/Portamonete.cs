using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Portamonete : MonoBehaviour
{
    int monete = 0;
    public TextMeshProUGUI contaMoneteText;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.name.Contains("Coin")) {
            monete++;
            collision.gameObject.SetActive(false);
            AggiornaConteggioMonete();
        }
    }

    void AggiornaConteggioMonete() {
        if (monete < 10) {
            contaMoneteText.SetText("0" + monete);
        } else {
            contaMoneteText.SetText("" + monete);
        }
    }
}