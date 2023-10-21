using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WraithScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D myRigidBody;
    //reference to the Rigid Body component 
    public float jumpStrength;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if space is pressed, sprite moves up 
        if (Input.GetKeyDown(KeyCode.Space)) {      
            myRigidBody.velocity = Vector2.up * jumpStrength;
        }
    }
}
