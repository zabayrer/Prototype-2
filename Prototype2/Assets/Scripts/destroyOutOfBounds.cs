using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOutOfBounds : MonoBehaviour
{
    private float topBound = 40;
    private float bottomBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if an object goes past the game view, KILL IT
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }else if (transform.position.z < bottomBound)
            {
                Destroy(gameObject);
                //tell the player that they are dead
                Debug.Log("Game Over!");
            }
        } 
    }
