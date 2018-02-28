using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movenemy : MonoBehaviour 
{
	public float enemi;
	public float camina;
	public float hsalto;
	public float veloMov;

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "ladrillo")
		{
			print ("");
		}    
	}


	void Update() 
	{

		if (Input.GetKey(KeyCode.Space))
		{
			GetComponent<Rigidbody2D> ().velocity= new Vector2 (veloMov, GetComponent<Rigidbody2D> ().velocity.y);

		}

		if (Input.GetKey(KeyCode.V))
		{
			GetComponent<Rigidbody2D> ().velocity= new Vector2 (-veloMov, GetComponent<Rigidbody2D> ().velocity.y);

		}
	}
}
