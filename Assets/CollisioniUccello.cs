using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisioniUccello : MonoBehaviour
{string messaggio="HAI PERSO";
public TextMeshProUGUI scriviHaiPerso;
    private void OnTriggerEnter2D(Collider2D collision){
            this.gameObject.SetActive(false);
            scriviHaiPerso.SetText(messaggio);
    }
}
