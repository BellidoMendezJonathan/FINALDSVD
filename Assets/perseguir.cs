using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : hpenemigos
{
   
    public Transform obj;
    public float speed;
    public bool perseguir;
    public float distancia;
    public float distanciaabsoluta;
    public hpjugador hpj;
    public float diferenciaY;
    public float attackCooldown = 2;
    private float lastAttackTime;
    private void Start()
    {
        lastAttackTime = attackCooldown;
    }
    private void Update()
    {
        distancia = (obj.position.x +  obj.position.y) - (transform.position.x + transform.position.y);

        distanciaabsoluta = Mathf.Abs(distancia);
        diferenciaY = Mathf.Abs(obj.position.y - transform.position.y);

        if (perseguir == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, obj.position, speed * Time.deltaTime);
        }

        if (distancia > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);

        }
        if (distancia < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (distanciaabsoluta < 11)

        {
            perseguir = true;
        }


        else
        {
            perseguir = false;
        }

        if ((distanciaabsoluta <= 0.1f) && perseguir == true && obj.CompareTag("Player") && diferenciaY < 0.5f)

        {
            lastAttackTime = Time.time;
            hpj.Tomardaño(daño);
        }

    }

    protected override void Muerte()
    {

        base.Muerte();
        Invoke("Expp", 0.4f);
        expp.SetActive(true);
    }
  private void Expp()
    {
        expp.SetActive(false);
    }
}
