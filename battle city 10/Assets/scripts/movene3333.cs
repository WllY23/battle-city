using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movene3333 : MonoBehaviour 
{
	public float vel = 2F;
	public bool mov;
	public bool mov2;

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "muro")
		{
			if (mov == true)
			{
				mov = false;
			}
			else if (mov == false)
			{
				mov = true;
			}
		}  
	}
	void Update () 
	{
		if (mov == true) 
		{
			transform.Translate (Vector2.left * vel * Time.deltaTime);
		}
		if (mov==false)
		{
			transform.Translate (Vector2.right * vel * Time.deltaTime);
		}
		if (mov == true)
		{
			mov2 = false;
			transform.Translate (Vector2.up * vel * Time.deltaTime);
		}
		if (mov == false)
		{
			mov2 = true;
			transform.Translate (Vector2.down * vel * Time.deltaTime);
		}
//		if (mov == true) 
//		{
//			transform.Translate (Vector2.left * vel * Time.deltaTime);
//		}
//		if (mov==false)
//		{
//			transform.Translate (Vector2.right * vel * Time.deltaTime);
//		}
//		if (mov == true)
//		{
//			mov2 = false;
//			transform.Translate (Vector2.down * vel * Time.deltaTime);
//		}
//		else if (mov == false)
//		{
//			mov2 = true;
//			transform.Translate (Vector2.up * vel * Time.deltaTime);
//		}
	}  
		
	}

//	void FixedUpdate ()
//	{
//		rigidbody2D.AddForce (10.0F * Vector3.up);
//	}
//


