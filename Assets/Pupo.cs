using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pupo : MonoBehaviour
{

    Rigidbody2D rb;
    public float velocita = 350;
    public float altezzaSalto =5;
    bool isSaltoRilasciato = false;

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

        if(Input.GetAxisRaw("Jump") > 0 && isSaltoRilasciato)
        {
            rb.AddForce(Vector2.up, ForceMode2D.Impulse);
            isSaltoRilasciato = false;
        }
        else if (!isSaltoRilasciato && Input.GetAxisRaw("Jump") < 1.1)
        {
            isSaltoRilasciato = true;
        }
    }
}
