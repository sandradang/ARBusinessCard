using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbScript : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject vbButtonObject;
	private GameObject crocodile; 
	Animator animator;
	// Use this for initialization
	void Start () {

		vbButtonObject = GameObject.Find ("actionButton");
		crocodile = GameObject.Find ("crocodilelow");
		vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		animator = crocodile.GetComponent<Animator>();

	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){

		Debug.Log ("Button pressed!!!");

			animator.SetBool("Walk", true);

	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
		Debug.Log ("Button released!!!");

	}
}
