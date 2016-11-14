using UnityEngine;
using System.Collections;

public class animations : MonoBehaviour {

	private Animator anim;

	public float ver;
	public float hor;
	public float sprint;

	// Use this for initialization
	void Start () {
	
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
	
		ver = Input.GetAxis ("Vertical");
		hor = Input.GetAxis ("Horizontal");
		Sprinting();
	}

	void FixedUpdate () {

		anim.SetFloat ("Walk", ver);
		anim.SetFloat ("Turn", hor);
		anim.SetFloat ("Sprint", sprint);

	}

	void Sprinting () {
	
		if (Input.GetKey (KeyCode.LeftShift)) {
			sprint = 0.2f;
		} else {
			sprint = 0.0f;
		}
	
	}

}
