using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pocohp : MonoBehaviour

{
    public hpjugador jugadorHP;

    public GameObject au;
    public AudioSource bajar;

    public Text textoCuidado;
    private void Start()
    {
       
        bajar = bajar.GetComponent<AudioSource>();
    }

    void Update()
    {

        textoCuidado.text = jugadorHP.vida <= 20 ? "!POCOS HP!" : " ";
        audiocontroler();
    }

    void audiocontroler()
    { 
        if (jugadorHP.vida <= 20)
        {
            au.SetActive(true);
            bajar.volume = 0.07f;

        }

        if (jugadorHP.vida > 20)

        {
            au.SetActive(false);
            bajar.volume = 1;
        }        

    }
}



