using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    //Added bonus: The pellet follows the crosshair/mouse, so you can actually make your shots hit animals instead of going to a set location.

    public Transform start;
    public Transform end;
    public float t;
    public AnimationCurve curve;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if(t > 1)
        {
            t = 0;
        }

        // transform.position = Vector2.Lerp(start.position, end.position, t);
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
    }
}
