using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaggio : MonoBehaviour
{

     Rigidbody2D rb;
     public float velocita = 150;
     public float altezzaSalto = 150000000;
     bool isSpazioRilasciato = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimentoX = Input.GetAxisRaw("Horizontal") * velocita * Time.deltaTime ;
        float movimentoY = rb.velocity.y;
        rb.velocity = new Vector2(movimentoX, movimentoY);

        if(Input.GetAxisRaw("Jump") > 0 && isSpazioRilasciato) {
            rb.AddForce(Vector2.up * altezzaSalto, ForceMode2D.Impulse);
            isSpazioRilasciato = false;
        }
        else if (!isSpazioRilasciato && Input.GetAxisRaw("Jump") < 1) {
            isSpazioRilasciato = true;
        }
    }
}
