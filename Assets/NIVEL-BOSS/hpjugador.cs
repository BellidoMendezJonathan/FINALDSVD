using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hpjugador : MonoBehaviour
{public GameObject sslider;
    public Animator transition;
    public GameObject player;
    public AudioSource clip;
  
    private Animator anim;

    [Header("Vida")]
    [SerializeField] public float vida;
    [SerializeField] private BarraHP barrahp;
    [SerializeField] private float maxvida;
    // Start is called before the first frame update
    void Start()
    {
        barrahp.IniciarBarra(vida);
        vida = maxvida;
       
        anim = GetComponent<Animator>();
    }
    public void Tomardaño(float daño)
    {
        vida -= daño;
        barrahp.CambiarHPactual(vida);
        Debug.Log("daño");
        if (vida <= 0)
        {
            player.tag = new("muerto");
            StartCoroutine(SceneLoad(3));
            anim.SetTrigger("die");
            player.GetComponent<movplayer>().velocidadmov = 0f;
            player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            player.GetComponent<melé>().enabled = false;

            if(player.GetComponent<movplayer>().velocidadmov > 0.1f & vida == 0)
            {
                Input.ResetInputAxes();
            }

        }
    }
    // Update is called once per frame
    void Update()
    {

    }

   
    public IEnumerator SceneLoad(int sceneindex)

    {
        transition.SetTrigger("START");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneindex);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("item"))
        {
           
            clip.Play();
            Destroy(collision.gameObject);
            barrahp.curarhp(10);
            vida += 10;
        }
    }
}
