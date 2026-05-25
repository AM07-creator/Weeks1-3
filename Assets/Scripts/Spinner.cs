using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float zMax;
    public float zMin;
    public float speed = 30f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("Let the game commence!");
        //Debug.Log(transform.eulerAngles);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z += speed * Time.deltaTime;
        transform.eulerAngles = currentRotation;

        if (currentRotation.z > zMax)
        {
            Debug.Log("Crossing the upper threshold currentZ[" + currentRotation.z.ToString() + "] zMax[" + zMax.ToString() + "]");
            speed = -speed;
            //speed *= -1f;
        }
        if (currentRotation.z < zMin)
        {
            Debug.Log(("Crossing the upper threshold currentZ[" + currentRotation.z.ToString() + "] zMax[" + zMax.ToString() + "]"));
            speed = -speed;
        }


        //My Excersize Code
        //if (currentRotation.z > zMax )
        //{
        //    currentRotation.z -= 30f * Time.deltaTime;
        //    Debug.Log("rotating clockwise");
        //}
        //if (currentRotation.z < zMin)
        //{
        //    currentRotation.z -= 30f * Time.deltaTime;
        //    Debug.Log("rotating counter-clockwise");
        //}
    }
}
