using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float ms=0.01F;
    public float dead= -11.32F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * ms)* Time.deltaTime;
        if(transform.position.x<dead){
            Destroy(gameObject);
        }
        
    }
}
