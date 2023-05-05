using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f; // velocità di movimento del nemico
    public float fireRate = 2f; // frequenza di fuoco del nemico
    public float damage = 10f; // quantità di danno inflitto dal nemico

    private Transform player; // riferimento al GameObject del giocatore
    private float nextFireTime; // prossimo momento in cui il nemico può sparare

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // muovi il nemico verso il giocatore
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        // sparare se il giocatore è nel raggio d'azione e se è il momento giusto
        if (Vector3.Distance(transform.position, player.position) < fireRange && nextFireTime <= 0f)
        {
            Fire();
            nextFireTime = 1f / fireRate;
        }
        else
        {
            nextFireTime -= Time.deltaTime;
        }

        // infliggere danni al giocatore se è nel raggio d'azione
        if (Vector3.Distance(transform.position, player.position) < damageRange)
        {
            player.GetComponent<Player>().TakeDamage(damage);
        }
    }

    // metodo per sparare
    void Fire()
    {
        // implementazione dello sparo
    }
}
