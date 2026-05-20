using UnityEngine;

public class SimpleEnemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D rb;
    BoxCollider2D collider2D;
    float direction;
    float timer = 0f;
    public double hp = 5;
    public GameObject enemy;
    public Movement player;
    
    void Start()
    {
        direction = 1f;
        rb = GetComponent<Rigidbody2D>();
        collider2D = GetComponent<BoxCollider2D>();
        rb.freezeRotation = true;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector2(direction * 5f, rb.linearVelocityY);
        timer += Time.deltaTime;
        if (hp <= 0)
        {

            enemy.SetActive(false);
        }
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
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Weapon 1"))
        {
            hp -= player.dmg;   
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


