using UnityEngine;
using System.Collections;

public class SoundDestroyer : MonoBehaviour {

	public float time;
	private float timer;
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > time) 
		{
			Destroy (gameObject);
		}
	}
}
