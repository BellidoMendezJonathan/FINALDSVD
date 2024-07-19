using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static enumerador.AmbientSoundState;

public class activarjefe : MonoBehaviour
{
    public GameObject jefe;
    public GameObject slider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(ChangeMusicAndActivateObjects());
        }
    }

    private IEnumerator ChangeMusicAndActivateObjects()
    {
        
       enumerador.ChangeAmbientSound(Combat);

     
        yield return null;

        jefe.SetActive(true);
        slider.SetActive(true);
    }
}
