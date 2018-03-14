using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goomba : MonoBehaviour {

	//public variables(variable in editor)
	public float damage = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//called  when trigger collides with anouther collider
	void OnTriggerStay2D(Collider2D other)
	{
		//attempting to get the player script from the colider
		player playerscript = other.GetComponent<player> ();

		//if the player script does collide
		if (playerscript != null) {
			// calling the damage function on the script then applying the damage
			playerscript.Damage (damage);

			Debug.Log ("goomba dealt damage to player = " + damage);
		}//end if (playerscript != null)
	} //end ontriggerenter2d()




}
