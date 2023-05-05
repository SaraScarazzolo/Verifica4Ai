using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RaccogliMonete : MonoBehaviour
{
    int monete=0;
    public TextMeshProUGUI contaMonete;
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.name.Contains("Coin")){
            monete++;
            collision.gameObject.SetActive(false);
            contaMonete.SetText("Monete: "+monete);
        }
    }
}
