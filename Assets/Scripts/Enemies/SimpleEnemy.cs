using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleEnemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D rb;
    BoxCollider2D collider2D;
    float direction;
    float timer = 0f;
    public double hp = 5;
    public GameObject enemy;
    public SimpleEnemy simple;
    public GameObject player;
    public Movement playercode;

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

    public int moneyReward = 10;
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
            Geld_anzeige.Instance.AddMoney(10);
            Debug.Log("Simple Enemy gestorben");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            if (direction == 1f)
            {
                direction = -1f;
                // ChatGPT code anfang für die Animation
                transform.localScale = new Vector3(-1, 1, 1);
                // ChatGPT code ende
                Debug.Log("Enemy lauft nach links");
            }
            else if (direction == -1f)
            {
                direction = 1f;
                // ChatGPT code anfang für die Animation
                transform.localScale = new Vector3(1, 1, 1);
                // ChatGPT code ende
                Debug.Log("Enemy lauft nach rechts");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Weapon 1"))
        {
            hp -= playercode.dmg;
            Debug.Log("Enemy nimmt Schaden");
            if (player.transform.position.x > enemy.transform.position.x)
            {
                direction = -1;
                // ChatGPT code anfang für die Animation
                transform.localScale = new Vector3(-1, 1, 1);
                // ChatGPT code ende
            }
            else
            {
                direction = 1;
                // ChatGPT code anfang für die Animation
                transform.localScale = new Vector3(1, 1, 1);
                // ChatGPT code ende
            }
            

        }
    }

}


