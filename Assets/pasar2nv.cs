using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pasar2nv : MonoBehaviour
{ public Animator transition;
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
        if (collision.gameObject.CompareTag("n"))
        {
            {
                StartCoroutine(SceneLoad(2));
            }
        }
    }
            public IEnumerator SceneLoad(int sceneindex)

            {
                transition.SetTrigger("START");
                yield return new WaitForSeconds(1);
                SceneManager.LoadScene(sceneindex);
            }
    
}