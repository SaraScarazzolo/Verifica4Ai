using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p0 : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float velocita = 100;

    void start () {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        float movimentiX = Input.GetAxisRaw("Horizontal")*velocita*Time.deltaTime;
        float movimentiY = rb.velocity.y;
        rb.velocity = new Vector(movimentiX,movimentiY);
    }
}
