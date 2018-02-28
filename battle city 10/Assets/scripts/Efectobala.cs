using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Efectobala : MonoBehaviour
{
    public float tiempodevida;
    public float vel = 1F;
    public GameObject Pref_Explosion;

    public void Destruir()
    {
        Destroy(this.gameObject, tiempodevida);
        transform.Translate(Vector2.up * vel  * Time.deltaTime);
    }

    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != null)
        {
            GameObject explosion = Instantiate(Pref_Explosion, collision.contacts[0].point, Quaternion.identity);
            Destroy(explosion, 1.5f);
            Destroy(this.gameObject);
        }

    }
}