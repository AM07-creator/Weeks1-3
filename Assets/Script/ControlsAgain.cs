using UnityEngine;
using UnityEngine.InputSystem;

public class ControlsAgain : MonoBehaviour
{
    public bool leftArrowPressed = false;
    public bool rightArrowPressed = false;
    public float speed = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Was released for the first frame the key is released only
        if(Keyboard.current.leftArrowKey.isPressed == true)
        {
            Vector2 newPosition = transform.position;
            newPosition.x -= speed * Time.deltaTime;
            transform.position = newPosition;
        }
        if (Keyboard.current.rightArrowKey.isPressed == true)
        {
            Vector2 newPosition = transform.position;
            newPosition.x += speed * Time.deltaTime;
            transform.position = newPosition;
        //keep tank in world space
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
            if(screenPos.x < 0 || screenPos.x > Screen.width)
            {
                speed = 0;
            }
        }
    }
}
