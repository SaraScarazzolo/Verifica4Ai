using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaggio : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed;

    void FixedUpdate () {
        float horizontal = input.GetAxis ("Horizontal");
        float vertical = input.GetAxis ("Vertical");

        GetComponent<Rigidbody2D> ().velocity = new Vector2 (horizontal * speed, vertical * speed);
    }
}
