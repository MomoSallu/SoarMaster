using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed = 2;
    public float offScreenZone = -5;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime; //Makes sure that the multplication doesn't factor the fps

        if (transform.position.x < offScreenZone)
        {
            Debug.Log("Obstacle deleted");
            Destroy(gameObject);
        }
    }
}
