using UnityEngine;

public class BulletTravel : MonoBehaviour
{
	//Added bonus: The pellet follows the crosshair/mouse, so you can actually make your shots hit animals instead of going to a set location.


	//Set the start and finish points for the Lerp by declaring public transform variables. Declare a public animation curve variable to be customized in the inspector. Public time variable for bullet's current travel time
	public Transform empty;
	public Transform crosshair;
	public float t;
	public AnimationCurve curve;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		//Count up to a second. If a second has passed, reset the timer back to 0
		t += Time.deltaTime;
		if (t > 1)
		{
			t = 0;
		}

		//The transform of the bullet is started at a strat position and ends at an end position (declared with the empty and crosshair transform variables.) The animation curve will complete the transformation overtime based on the variable t.
		//In other words, after a second the bullet will have completed the traversal and can have its distance overtime altered by an animation curve, however this distance overtime is already dynamic because the end position is your mouse
		transform.position = Vector2.Lerp(empty.position, crosshair.position, curve.Evaluate(t));
	}
}
