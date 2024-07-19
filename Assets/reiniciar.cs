using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class reiniciar : MonoBehaviour
{

   
    public Animator transition;

    // Start is called before the first frame update
    void Start()
    {
        transition = GetComponentInChildren<Animator>();

    }

    // Update is called once per frame


    public IEnumerator SceneLoad(int sceneindex)

    {
        transition.SetTrigger("START");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneindex);


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(SceneLoad(0));
        }
    }
}
