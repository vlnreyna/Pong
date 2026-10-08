
using UnityEngine;

public class Player1 : MonoBehaviour
{

    public float speed = 3f;
    public float limit = 2f;
    public float dir;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) && transform.position.y <= limit) 
        {
            dir = 1f;
        } 
        else if (Input.GetKey(KeyCode.S) && transform.position.y >= -limit) 
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