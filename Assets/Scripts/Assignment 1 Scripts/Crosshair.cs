using UnityEngine;
using UnityEngine.InputSystem;

public class Crosshair : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Whereever the mouse is, the crosshair gameobject will follow it
		Vector2 crosshairPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
		
		transform.position = crosshairPos;
	}
}
