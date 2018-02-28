using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class casoene : MonoBehaviour
{
    public int direccion;
    public float vel = 2F;
    public float ultimadir;
    public Animator animatorenemi;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "muro" || coll.gameObject.tag == "ladrillo")
        { 
            do
            {
                direccion = Random.Range(1, 5);
            } while (ultimadir == direccion);
        }
    }

    private void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "muro" || coll.gameObject.tag == "ladrillo")
        {
            do
            {
                direccion = Random.Range(1, 5);
            } while (ultimadir == direccion);
        }
    }

    void Start ()
    {
        direccion = Random.Range(1,5);
       // print(direccion);
    }
	void Update ()
    {
        switch (direccion)
        {
            case 1:
                this.transform.Translate(Vector2.left * vel * Time.deltaTime);
                animatorenemi.SetTrigger("left");
                break;
            case 2:
                this.transform.Translate(Vector2.right * vel * Time.deltaTime);
                animatorenemi.SetTrigger("rigth");
                break;
            case 3:
                this.transform.Translate(Vector2.up * vel * Time.deltaTime);
                animatorenemi.SetTrigger("up");
                break;
            case 4:
                this.transform.Translate(Vector2.down * vel * Time.deltaTime);
                animatorenemi.SetTrigger("down");
                break;
        }
        ultimadir = direccion;
    }
}
