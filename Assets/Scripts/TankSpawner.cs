using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankSpawner : MonoBehaviour
{
    public GameObject tankPrefab;
    public int howManyTanks = 0;
	public GameObject spawnedTank;

	public FirstScript tankScript;

    public List<GameObject> tanks;
    public Transform barrel;
    public GameObject duckiePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            //Instantiate a Prefab: make this one appear
            //Instantiate a Prefab, a Vector2 or Vector3, a Quaternion: make it appear at this position and rotation
            //Instantiate(tankPrefab, transform.position, transform.rotation);

            //Vector2 spawnPos = Random.insideUnitCircle * 3;
            //Quaternion.identity means no rotation, which is the same as the Euler angles being (0,0,0)
            spawnedTank = Instantiate(tankPrefab, transform.position, transform.rotation);

			tankScript = spawnedTank.GetComponent<FirstScript>();

            howManyTanks += 1;

            tanks.Add(spawnedTank);

            Instantiate(duckiePrefab, Random.insideUnitCircle * 3, Quaternion.identity);
       
        }
		if (Mouse.current.rightButton.wasPressedThisFrame == true)
		{
            tanks.Remove(spawnedTank);
			Destroy(spawnedTank);
		}
        //loop through list of tanks: GameObjects
        //get the tank's transform
        //Compare that to the barrel: is the tank at the same position as the barrel?
        for (int i = tanks.Count - 1; i >= 0; i--)
        {
            float distance = Vector2.Distance(tanks[i].transform.position, barrel.position);
            if (distance < 0.5f)
            {
                Debug.Log("exlpode tank" + i);
                //make a local variable to get to a reference to the tank
                GameObject tank = tanks[i];
                //remove the tank from the list
                tanks.Remove(tank);
                //destroy the tank
                Destroy(tank);
            }
        }
    }
}
