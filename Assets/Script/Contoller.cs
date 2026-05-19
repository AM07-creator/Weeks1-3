using UnityEngine;
using UnityEngine.InputSystem;

public class Contoller : MonoBehaviour
{

    public float moveSpeed;
    public float rotateSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isUpHeld = Keyboard.current.upArrowKey.isPressed;
        if (isUpHeld == true)
        {
            //Vector3 currentPosition = transform.position;
            //currentPosition.y += moveSpeed;
            //transform.position = currentPosition;

            transform.position += transform.up * moveSpeed * Time.deltaTime;
        }

        bool isDownHeld = Keyboard.current.downArrowKey.isPressed;
        if (isDownHeld == true)
        {
            transform.position -= transform.up * moveSpeed * Time.deltaTime;
        }
        bool isLeftHeld = Keyboard.current.leftArrowKey.isPressed;
        if (isLeftHeld == true)
        {
            transform.eulerAngles -= transform.forward * moveSpeed * Time.deltaTime;
        }
        bool isRightHeld = Keyboard.current.rightArrowKey.isPressed;
        if (isRightHeld == true)
        {
            transform.eulerAngles += transform.forward * moveSpeed * Time.deltaTime;
        }

        //My Excersize code
        //Vector3 controller = transform.position;


        //bool upIsPressed = Keyboard.current.upArrowKey.isPressed;
        //bool downIsPressed = Keyboard.current.downArrowKey.isPressed;
        //bool rightIsPressed = Keyboard.current.rightArrowKey.isPressed;
        //bool leftIsPressed = Keyboard.current.leftArrowKey.isPressed;

        //if (upIsPressed == true)
        //{
        //    controller = transform.position;
        //}
        //if (downIsPressed == true)
        //{
        //    controller = transform.position;
        //}
        //if (rightIsPressed == true)
        //{
        //    controller = transform.position;
        //}
        //if (leftIsPressed == true)
        //{
        //    controller = transform.position;
        //}
    }
}
