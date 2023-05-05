using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    Rigidbody2D rb;
    public float velocita=50;
    public float altezzaSalto=10;
    bool isSaltoRilasciato=false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimentoX=Input.GetAxisRaw("Horizontal")*velocita*Time.deltaTime;
        float movimentoY=rb.velocity.y;

        rb.velocity = new Vector2(movimentoX,movimentoY);

        if(Input.GetAxisRaw("Jump")>0 && isSaltoRilasciato){
            print("ENTRATO");
            rb.AddForce(Vector2.up*altezzaSalto, ForceMode2D.Impulse);
            print("NO");
            isSaltoRilasciato=false;
        }else if(Input.GetAxisRaw("Jump")<1 && !isSaltoRilasciato){
            print("SALTATO");
            isSaltoRilasciato=true;
        }
    }
}
