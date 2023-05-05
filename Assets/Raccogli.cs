using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Raccogli : MonoBehaviour
{
    int moneta = 0;
    public TextMeshProUGUI conteMoneteText;
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.name.Contains("coin")){
            moneta++;
            collision.gameObject.SetActive(false);
            conteMoneteText.SetText("Coin: " + moneta);
        }

    }
}
