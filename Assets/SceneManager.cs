using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagerr : MonoBehaviour
{
   
    [SerializeField] private float trtime;
    private Animator transition;
    
    // Start is called before the first frame update
    void Start()
    {
        transition = GetComponentInChildren<Animator>();

    }

    // Update is called once per frame
    public void Load()
    {
        StartCoroutine(SceneLoad(1));
    }
    public void Lload()
    {
        StartCoroutine(SceneLoad(2));
    }
    public IEnumerator SceneLoad(int sceneindex)

    {
        transition.SetTrigger("START");
        yield return new WaitForSeconds(trtime);
        SceneManager.LoadScene(sceneindex);


    }
    public void Loadd()
    {
        StartCoroutine(SceneLoad(0));
     
     
    }
   
    
}
