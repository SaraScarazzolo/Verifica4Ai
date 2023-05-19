using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    Rigidbody2D rb;
    public float velocita = 5000 ;
    public float altezzaSalto = 1;
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
        /*if (rb.velocity.y > 21) {
            this.gameObject.SetActive(false);
        }
        if (Input.GetAxisRaw("Horizontal") < -37.5) {
            this.gameObject.SetActive(false);
        }
        if (rb.velocity.x > 36 && rb.velocity.y < 3 && rb.velocity.y > -8.3) {
           // hai vinto
        }*/
    }
}
