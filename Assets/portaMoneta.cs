using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portaMoneta : MonoBehaviour
{
 int monete=0;
    
    private void OnTriggerEnter2D(Collider2D collision){
        
        if(collision.name.Contains("Coin")){
        monete+=1;
        collision.gameObject.SetActive(false);
        print("Ho raccolto una moneta e ne ho "+monete);
        }
         if(collision.name.Contains("BigCoin")){
        monete+=5;
        collision.gameObject.SetActive(false);
        print("Ho raccolto un enorme moneta e ne ho "+monete);
        }
    }
}
