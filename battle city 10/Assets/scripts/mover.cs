using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour 
{
	public float andar;
	public Animator animator;
	public bool tocar;
	public float radio;
	public LayerMask obstaculos;

	    //void OnCollisionEnter2D(Collision2D coll)
    //	{
	    //	if (coll.gameObject.tag == "ladrillo")
		    //{
			    //print ("");
	    //	}    
	    //}

	void Update()
	{
//				if (pusarlo.pause == true) 
//				{
//					return;
//				}

		if (Input.GetAxis("Horizontal") !=0 && Input.GetAxis("Vertical") == 0) 
		{
			if (Input.GetAxis("Horizontal")>0) 
			{
				this.transform.Translate (Vector2.right * (andar * Time.deltaTime));
				animator.SetTrigger ("right");
			}

			if (Input.GetAxis("Horizontal")<0) 
			{
				this.transform.Translate (Vector2.left * (andar * Time.deltaTime));
				animator.SetTrigger ("left");
			}
		}

		if(Physics2D.OverlapCircle(transform.position, radio, obstaculos))
		{
			print("EntraOverlap");
		}


		if (Input.GetAxis("Vertical") !=0 && Input.GetAxis("Horizontal") ==0) {
			if (Input.GetAxis("Vertical")>0) 
			{
				this.transform.Translate (Vector2.up * (andar * Time.deltaTime));
				animator.SetTrigger ("up");
			}

			if (Input.GetAxis("Vertical")<0) 
			{
				this.transform.Translate (Vector2.down * (andar * Time.deltaTime));
				animator.SetTrigger ("down");
			}
		}
	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere (transform.position, radio);
	}
}
