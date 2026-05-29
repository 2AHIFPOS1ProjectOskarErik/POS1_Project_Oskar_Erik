using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyFollow : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D rb;
    BoxCollider2D collider2D;
    float direction;
    float timer = 0f;
    public double hp = 5;
    public GameObject enemy;
    public GameObject player;
    private Movement playercode;

    public int moneyReward = 10;
    

    private void Awake()
    {
        DontDestroyOnLoad(enemy);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        player = GameObject.Find("Player");
        playercode = player.GetComponent<Movement>();
    }
   

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void Start()
    {
        direction = 0f;
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
            Geld_anzeige.Instance.AddMoney(10);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            if (direction > 0f)
            {
                direction = direction *(-1);
            }
            else if (direction < 0f)
            {
                direction = direction * (-1);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Weapon 1"))
        {
            hp -= playercode.dmg;
            rb.linearVelocity = new Vector2(8f, 5f);
        }
    }

    public void Follow()
    {
        if (playercode.transform.position.x < transform.position.x)
        {
            direction = -1f;

        }
        if (playercode.transform.position.x > transform.position.x)
        {
            direction = 1f;
        }
    }
}
