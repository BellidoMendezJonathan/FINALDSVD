using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Soundimplemt : MonoBehaviour
{ 
    public AudioSource clip;
    public GameObject gameObjectt;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            clip.Play();
            Destroy(collision.gameObject);
            gameObjectt.GetComponent<hpjugador>().vida += 10;
           
        }
    }
}
        
