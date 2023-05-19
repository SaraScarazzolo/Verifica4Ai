using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class punteggio : MonoBehaviour
{
    int punteggioF = 0;

    public TextMeshProUGUI contapunti;

    // Update is called once per frame
    void Update()
    {
        print(Time.deltaTime);
        if (Time.deltaTime == 1 ){
            aggiorna();
        }
        
    }

    void aggiorna(){
        punteggioF++;
        contapunti.SetText("Punti: "+ punteggioF);
    }
}
