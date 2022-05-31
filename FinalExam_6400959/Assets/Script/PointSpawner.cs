using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] PointSpawners;
    [SerializeField] private GameObject Point;
    private float TimeBetween=0;
   
    



    // Start is called before the first frame update
    void Start()
    {

        
        //int randomIndex = Random.Range(0, PointSpawners.Length);
        // Transform spawner = PointSpawners[randomIndex];

        //Instantiate(Point, spawner.position, Quaternion.identity);



    }

    // Update is called once per frame
    void Update()
    {

        if (TimeBetween <= 3)
        {

            int randomIndex = Random.Range(0, PointSpawners.Length);
            Transform spawner = PointSpawners[randomIndex];

            Instantiate(Point, spawner.position, Quaternion.identity);

            TimeBetween++;
        }


    }

   
}
