using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe1;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        //spawnPipe();
        //Instantiate(pipe1, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            //Instantiate(pipe1, transform.position, transform.rotation);
            timer = 0;
        }

        //spawnPipe();




    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        //Instantiate(pipe1, transform.position, transform.rotation);
        Instantiate(pipe1, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint)), transform.rotation);
    }
}
