using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaggio : MonoBehaviour
{

    Rigidbody2D rb;
    public float velocita;
    public float altezzaSalto;
    bool isSaltoRilasciato = false;

    // Start is called before the first frame update
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

        if (Input.GetAxisRaw("Jump") > 0 && isSaltoRilasciato) {
            rb.AddForce(Vector2.up * altezzaSalto, ForceMode2D.Impulse);
            isSaltoRilasciato = false;
        } else if (Input.GetAxisRaw("Jump") < 1 && !isSaltoRilasciato) {
            isSaltoRilasciato = true;
        }
    }
}