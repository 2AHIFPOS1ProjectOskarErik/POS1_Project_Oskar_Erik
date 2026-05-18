using UnityEngine;

public class SimpleEnemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D rb;
    BoxCollider2D collider2D;
    float direction;
    float timer = 0f;
    double hp = 5;
    public GameObject enemy;
    
    void Start()
    {
        direction = 1f;
        rb = GetComponent<Rigidbody2D>();
        collider2D = GetComponent<BoxCollider2D>();
        rb.freezeRotation = true;
        if (hp <= 0)
        {
            enemy.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector2(direction * 5f, rb.linearVelocityY);
        timer += Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            if (direction == 1f)
            {
                direction = -1f;
            }
            else if (direction == -1f)
            {
                direction = 1f;
            }
        }
        if (collision.gameObject.CompareTag("Weapon 1"))
        {
            if (direction == 1f)
            {
                direction = -1f;
            }
            else if (direction == -1f)
            {
                direction = 1f;
            }
        }
    }
}


