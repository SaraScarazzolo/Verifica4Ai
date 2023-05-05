using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coin : MonoBehaviour
{

int monete = 0;
public TextMeshProUGUI ContaMonete;

    private void OntriggerEnter2D(Collider2D collision){

	    if (collision.name.Contains("coin")){
		    monete++;
		    collision.gameObject.SetActive(false);
            print(monete);
            AggionaConteggioMonete();
	    }
    }

    void AggionaConteggioMonete(){
	    ContaMonete.SetText("Coin collected " + monete);
    }
}
