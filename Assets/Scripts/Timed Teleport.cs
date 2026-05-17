using UnityEngine;

public class TimedTeleport : MonoBehaviour
{
    public float timer = 0;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Reset Timer
        timer += Time.deltaTime;
        if(timer > 3)
        {
            timer = 0;
            //Change transform
            transform.position = (Vector2)transform.position + Random.insideUnitCircle * 2;
        }
    }
}
