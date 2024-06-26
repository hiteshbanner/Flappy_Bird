using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public LogicScript logic;
    public bool birdsAlive=true;
    // Start is called before the first frame update
    void Start()
    {
        logic= GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)== true&& birdsAlive){
            myRigidbody.velocity = Vector2.up * 5;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D Collection){
        logic.gameOver();
        birdsAlive=false;
    }
}
