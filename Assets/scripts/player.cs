using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {


	public float speed =5;
	public float health = 100;
	public float invulnerableDuration = 1;
	public float blinkDuration = 0.25f;

	private float invulnerableEndTime = 0;
	private float blinkEndTime = 0;

	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		Rigidbody2D ourRigidBody = GetComponent<Rigidbody2D> ();

		float horizontal = Input.GetAxis ("Horizontal");

			Vector2 velocity = ourRigidBody.velocity;

		//set our velocity based on the input and our speed value
		velocity.x = horizontal * speed;

		//put this velocity back into the physics system
		ourRigidBody.velocity = velocity;

		//get our sprite render component attached to this object
		SpriteRenderer renderer = GetComponent<SpriteRenderer> ();

		//flip the sprite
		renderer.flipX = velocity.x < 0;

		//are we done being invunveriable?
		if (Time.time >= invulnerableEndTime) {
			//if NOT invunererable...

			//set the renderer to enabled
			renderer.enabled = true;
		} else {
			//if yes invunverable

			//if it is time to blink
			if(Time.time >= blinkEndTime) {
				//ser our renderer enable value to the opposite of what it currenttly is (toggle it)
				renderer.enabled = !renderer.enabled;
				//set the next time we should blink our current time plus the blink duration
				blinkEndTime = Time.time + blinkDuration;
			} // end if (Time.time >= blinkEndTime)  
		} // end if (Time.time >= invulnerableEndTime)  
	} // end Update()  
	
	//reducing health by the damage passed in
	public void Damage(float damageToDeal)
	{
		if (Time.time >= invulnerableEndTime) {
			health = health - damageToDeal;
			//TODO: Handle death

			//set us as invulnerable for a set duration
			invulnerableEndTime = Time.time + invulnerableDuration;

			//Log the result of the function 
			Debug.Log ("damage Was dealt");
			Debug.Log ("damagetodeal = " + damageToDeal);
			Debug.Log ("damagetodeal = " + health);
		}
			
	}//end damage ()
}