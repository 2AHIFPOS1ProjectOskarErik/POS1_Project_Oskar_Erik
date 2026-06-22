using System;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniBoss : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D rb;
    BoxCollider2D collider2D;
    float direction;
    float timer = 0f;
    public float maxHp = 60;
    public double hp = 5;
    public GameObject miniBoss;
    public GameObject player;
    private Movement playercode;
    private int Attacks;
    private float timerstop;
    private float timerMove;
    private Timer timerJump;
    public bool bossstart = false;
    private float pause = 2.5f;
    public GameObject bossgate;
    public GameObject bossgate2;
    public MiniBossHP hpcode;
    public GameObject hpcanvas;
    private bool hpactive = false;
    private bool isAlive = true;
    public int moneyReward = 10;


    private void Awake()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        player = GameObject.Find("Player");
        playercode = player.GetComponent<Movement>();
        bossgate = GameObject.Find("GateBoss");
    }


    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void Start()
    {
        direction = 0f;
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        
        collider2D = GetComponent<BoxCollider2D>();
    }


    // Update is called once per frame
    void Update()
    {
        
        if (playercode.MinibossAlive == false)
        {
            hp = 0;
        }
        if (timerMove > 1.5f)
        {
            direction = 0f;
            timerMove = 0f;
            timerstop = 0f;
            Attacks = 0;
        }

        rb.linearVelocity = new Vector2(direction * 5f, rb.linearVelocityY);
        timer += Time.deltaTime;

        if (hp <= 0)
        {
            
            hpcanvas.SetActive(false);
            miniBoss.SetActive(false);
            bossgate.SetActive(false);
            bossgate2.SetActive(false);
            Geld_anzeige.Instance.AddMoney(50);
            hpactive = true;
            playercode.MinibossAlive = false;
            Debug.Log("Miniboss gestorben");
        }

        if (bossstart == true)
        {
            if (hpactive == false)
            {
                hpcanvas.SetActive(true);
                Debug.Log("Miniboss HPbar aktiviert");
            }

            timerstop += Time.deltaTime;
            if (timerstop >= pause)
            {
                Attacks = GetRandatk();
                if (Attacks == 1)
                {
                    
                    timerMove += Time.deltaTime;
                    if (playercode.transform.position.x < transform.position.x)
                    {
                        direction = -1f;
                        Debug.Log("Miniboss läuft nach rechts");
                    }
                    if (playercode.transform.position.x > transform.position.x)
                    {
                        direction = 1f;
                        Debug.Log("Miniboss läuft nach links");
                    }
                    
                }
                else if (Attacks == 2)
                {
                    timerMove += Time.deltaTime;
                    if (playercode.transform.position.x < transform.position.x)
                    {
                        Debug.Log("Miniboss springt nach rechts");
                        direction = 1f;

                    }
                    if (playercode.transform.position.x > transform.position.x)
                    {
                        Debug.Log("Miniboss springt nach links");
                        direction = -1f;
                    }
                    
                    
                }
                else if (Attacks == 3)
                {
                    direction = 0f;
                }

                else if (Attacks == 4)
                {
                    if (playercode.transform.position.x < transform.position.x)
                    {
                        direction = -1f;

                    }
                    if (playercode.transform.position.x > transform.position.x)
                    {
                        direction = 1f;
                    }
                    Jump();
                }
                else if (Attacks == 5)
                {
                    if (playercode.transform.position.x < transform.position.x)
                    {
                        direction = -1f;

                    }
                    if (playercode.transform.position.x > transform.position.x)
                    {
                        direction = 1f;
                    }
                    Jump();
                }

                    timerstop = 0f;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            if (direction > 0f)
            {
                direction = direction * (-1);
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
            hpcode.UpdateHP();
        }
    }

    private int GetRandatk()
    {
        
        System.Random rand = new System.Random();
        return rand.Next(1,5);
    }

    private void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x * direction, 10f);
    }

}
