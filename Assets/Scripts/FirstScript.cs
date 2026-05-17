using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public float speed = 0.01f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Move Circle in both axes
        Vector2 newPos = transform.position;
        newPos.x += speed;
        transform.position = newPos;

        Vector2 newPos2 = transform.position;
        newPos2.y += speed;
        transform.position = newPos2;

        //Check if shape is at screen edge for both axes
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x < 0|| screenPos.x > Screen.width)
        {
            speed = speed * -1;
        }
		Vector2 screenPos2 = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPos.y < 0 || screenPos.y > Screen.height)
		{
			speed = speed * -1;
		}
	}
}
