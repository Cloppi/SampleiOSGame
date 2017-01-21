using UnityEngine;
using System.Collections;

public class CardControl : MonoBehaviour {

	public Animator anim;
	public bool open;
	public GameObject sound;

	// Use this for initialization
	public void OpenCard () {
		open = !open;
		anim.SetBool ("Open", open);
		Instantiate (sound);
	}

}
