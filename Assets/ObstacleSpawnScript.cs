using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject obstacle;
    public float obstacleSpawnTimer = 3;
    private float timer = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < obstacleSpawnTimer)
        {
            timer += Time.deltaTime;
        } else
        Instantiate(obstacle, transform.position, transform.rotation);
    }
}
