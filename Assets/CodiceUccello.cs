using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodiceUccello : MonoBehaviour
{

    Rigidbody2D rb;
    public float velocita = 300;
    public float altezzaSalto =3;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimentoX = Input.GetAxisRaw("Horizontal") * velocita * Time.deltaTime;
        float movimentoY = rb.velocity.y;

        rb.velocity = new Vector2(movimentoX, movimentoY);

        if(Input.GetAxisRaw("Jump") > 0)
        {
            rb.AddForce(Vector2.up, ForceMode2D.Impulse);
        }
    }
}