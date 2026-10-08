using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float speed = 3f;
    public Vector2 dir;
    public float moreSpeed = 0.2f;
    public float delay = 2f;
    public bool isMoving = false;

    public GameObject Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(BallStart());
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving == true)
        {
            transform.Translate(dir * speed * Time.deltaTime);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Wall"))
        {
            dir = new Vector2(dir.x, -dir.y);
        
        }

        if (other.CompareTag("Player") || other.CompareTag("Enemy"))
        {
            //dir = new Vector2(-dir.x , dir.y); 

            float y = (transform.position.y - other.transform.position.y) / (other.bounds.size.y / 2f);
            dir = new Vector2(-dir.x, y);
            speed += moreSpeed;

        }

        if (other.CompareTag("PlayerGoal"))
        {
            StartCoroutine(BallStart());
            GameManager.Instance.IncreasePlayerPoints();
        }

        if(other.CompareTag("EnemyGoal"))
        {
            StartCoroutine(BallStart());
            GameManager.Instance.IncreaseEnemyPoints();
        }

     }


    IEnumerator BallStart() //coroutine
    {
        isMoving = false;
        transform.position = Vector2.zero;
        float y = Random.Range(-0.6f, 0.6f);
        dir = new Vector2(Random.value < 0.5f ? -1f : 1f, y).normalized;
        speed = 10f;
        yield return new WaitForSeconds(delay);
        
        isMoving = true;
    }
}









