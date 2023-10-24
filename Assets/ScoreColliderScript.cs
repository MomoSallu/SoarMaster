using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreColliderScript : MonoBehaviour
{
    // Start is called before the first frame update
    public WraithScript wraith;
    public LogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        wraith = GameObject.FindGameObjectWithTag("Player").GetComponent<WraithScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.layer == 3) && wraith.playerIsAlive)
        {
            logic.addScore(1);
        }
    }
}
