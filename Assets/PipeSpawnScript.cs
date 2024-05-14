using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate =1.5F;
    private float timer =0.5F;
    public float heightOffset =0.1F;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pipe,transform.position,transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnrate){
            timer=timer+ Time.deltaTime;
        }
        else{
            float low= transform.position.y - heightOffset;
            float hig= transform.position.y + heightOffset;
            Instantiate(pipe,new Vector3(transform.position.x,Random.Range(low,hig),0),transform.rotation);
            timer=0;
        }
        
    }
}
