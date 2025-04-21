using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript  logic;
    public bool birdIsAlive = true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)==true && birdIsAlive==true)
        {
            myRigidbody.linearVelocity=Vector2.up * flapStrength;
        }
        if(transform.position.y > 2.5 || transform.position.y < -2.5)
        {
        logic.gameOver();
        birdIsAlive=false;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive=false;
    }
}
