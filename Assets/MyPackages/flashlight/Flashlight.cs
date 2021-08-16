using UnityEngine;
using System.Collections;

public class Flashlight : MonoBehaviour {

	public AudioClip soundOn;
	public AudioClip soundOff;

	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Mouse1))
		{
			if(GetComponentInChildren<Light>().enabled == false)
			{
				GetComponentInChildren<Light>().enabled = true;
				GetComponent<AudioSource>().clip = soundOn;
				GetComponent<AudioSource>().Play();
			}
			else
			{
				GetComponentInChildren<Light>().enabled = false;
				GetComponent<AudioSource>().clip = soundOff;
				GetComponent<AudioSource>().Play();
			}
		}
	}
}
