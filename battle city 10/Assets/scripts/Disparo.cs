using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{

    public GameObject proyectil;
    public Transform spawnpoint;
    public float force;
    public float cadence;
    private float t;
    public GameObject cañon;
 
    private void Start()
    {
        t = cadence;
    }

    private void Update()
    {

        if (t <= cadence)
        {
            t += Time.deltaTime;
        }
        //if (Input.GetButtonDown("Fire1") && t > cadence)
        if (Input.GetButtonDown("Fire1"))
        {
            t = 0;
            Disparar();
        }
        //print(Time.deltaTime );
  
    }
    void Disparar()
    {

        //force *= Time.deltaTime;
        GameObject bala = Instantiate(proyectil, spawnpoint.position, spawnpoint.rotation);
        //bala.transform.Translate(Vector2 .up * force );
        bala.GetComponent<Rigidbody2D>().AddForce(bala.transform.forward * force, ForceMode2D.Impulse);
        //print(force);
        bala.GetComponent<Efectobala>().Destruir();

    }

} 