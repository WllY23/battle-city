using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class vida : MonoBehaviour 
{
	public int puntosvida = 3;
	public Text vidas;
	public Text play1;
	public void puntovida ()
	{
		puntosvida = puntosvida - 1;
		vidas.text = puntosvida.ToString ();
		if (puntosvida <= 0)
		{
			SceneManager.LoadScene ("GameOver");
		}
	}
}
