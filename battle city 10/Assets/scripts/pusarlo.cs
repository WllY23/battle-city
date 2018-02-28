using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pusarlo : MonoBehaviour 
{
	public bool pause;
	void Start () 
	{
		pause = false;
	}

	void Update () 
	{
		if (Input.GetKey (KeyCode.P)) 
		{
			if (pause == true) 
			{
				pause = false;
			} 
		}
	}
}



