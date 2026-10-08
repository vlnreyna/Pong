
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 3f;
    public float limit = 2f;
    public float dir;
    public GameObject ball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (ball.transform.position.y > transform.position.y && transform.position.y <= limit) 
        {
            dir = 1f;       
        }
        else if (ball.transform.position.y < transform.position.y && transform.position.y >= -limit)
        {
            dir = -1f;
        }
        else
        {
            dir = 0f;
        }

        Vector2 move = new Vector2(0f, dir) * speed * Time.deltaTime;
        transform.Translate(move);
    }
}