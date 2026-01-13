using UnityEngine;
using UnityEngine.UIElements;

public class Challenge2Script : MonoBehaviour
{

    
    public float t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 3)
        {
            t = 0;
        }
        if (t < 0)
        {
            Vector2 randomPos = Random.insideUnitCircle * 5f; // radius = 5
            transform.position = new Vector3(randomPos.x, randomPos.y, 0f);

        }

    }
}
