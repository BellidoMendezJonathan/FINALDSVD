using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hptexto : MonoBehaviour
{ public hpjugador hp;
    public Text textoo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textoo.text = "" + hp.vida;

    }
}
