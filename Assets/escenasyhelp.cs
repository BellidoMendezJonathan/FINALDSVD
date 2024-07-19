using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class escenasyhelp : MonoBehaviour

{
    public GameObject panel2;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    
    } 

    public void Panelon()
    {
        panel.SetActive(true);
    }
 public void Paneloff()
    {
        panel.SetActive(false);
    }

    public void panel2on()
    {
        panel2.SetActive(true);
    }
    public void panel2off()
    {
        panel2.SetActive(false);
    }

}
