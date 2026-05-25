using UnityEngine;

public class AnimalMovement : MonoBehaviour
{

    public float speed = 0.01f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//Move animals on the x axis at a constant speed, then redirect them when they hit the edge of the screen into the opposite direction
		Vector2 animalPos = transform.position;
		animalPos.x += speed;
		transform.position = animalPos;

		//If the animal's position on the screen is ever to exceed the screen width or be less than screen width minamum (0), redirect the animal in the opposite direction by multiplying the speed by -1
		Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPos.x < 0 || screenPos.x > Screen.width)
		{
			speed = speed * -1;
		}
	}
}
