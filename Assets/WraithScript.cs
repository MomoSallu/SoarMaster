using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WraithScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D myRigidBody;
    //reference to the Rigid Body component 
    public float jumpStrength;
    public bool playerIsAlive = true;
    public LogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //if space is pressed, sprite moves up 
        if (Input.GetKeyDown(KeyCode.Space) && playerIsAlive) {      
            myRigidBody.velocity = Vector2.up * jumpStrength;
        }
        
        if(transform.position.y < -6 || transform.position.y > 6)
        {
            playerIsAlive = false;  
            logic.GameOver();
        }    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerIsAlive = false;
        logic.GameOver();
    }
}
