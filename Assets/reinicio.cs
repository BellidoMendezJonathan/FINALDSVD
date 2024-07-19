using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class reinicio : MonoBehaviour
{ public Animator transition;
    public hpjugador hpj;
    public float daño;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            {
              hpj.Tomardaño(daño);
            }
        }
    }
        
}
