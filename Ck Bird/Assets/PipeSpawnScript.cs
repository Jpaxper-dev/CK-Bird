using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate=7;
    private float timer =0;
    public float heightOffset=10;
    void Start()
    {
        Instantiate(pipe, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer=0;
        }
        void spawnPipe()
        {
            float lowestPoint =transform.position.y - heightOffset;
            float highestPoint=transform.position.y + heightOffset;

            Instantiate(pipe, new Vector3(transform. position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        }
    }
}
