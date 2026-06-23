using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D rb;
    BoxCollider2D collider2D;
    float direction;
    float timer = 0f;
    public double hp = 100;
    public double maxHP = 100;
    public GameObject boss;
    public GameObject player;
    private Movement playercode;
    private int Attacks;
    private float timerstop;
    private float timerMove;
    private Timer timerJump;
    private float timerAtk1;
    private float timerAtk2;
    private float timerSchockwave;
    public bool bossstart = false;
    private float pause = 2.5f;
    public GameObject bossgate;
    public BossHP hpcode;
    public GameObject hpcanvas;
    public GameObject bullet;
    private GameObject bulletinstance;
    private bool hpactive = false;
    public GameObject Atk1;
    public GameObject Atk2Shockwave;
    public GameObject Schockwave;
    public int moneyReward = 1000;
    private float schockwaveamt = 0;
    private bool schockwave = false;
    private bool isAlive = true;
    private Animator animator;

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
        // ChatGPT code anfang
        animator = GetComponent<Animator>();
        // ChatGPT code ende
        direction = 0f;
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        
        collider2D = GetComponent<BoxCollider2D>();
    }


    // Update is called once per frame
    void Update()
    {
        if (isAlive == false)
        {
            hp = 0;
        }
        if (hp <= 0)
        {
            Die();
            playercode.BossAlive = false;
        }
        
        if (bossstart == true)
        {
            hpcanvas.SetActive(true);
            timerAtk1 += Time.deltaTime;
            if (timerAtk1 >= 1.5f)
            {
                Atk1.SetActive(false);
            }
            timerAtk2 += Time.deltaTime;
            if (timerAtk2 >= 1.5f)
            {
                Atk2Shockwave.SetActive(false);
            }

            timerstop += Time.deltaTime;
            if (timerstop > 2f)
            {
                Attacks = GetRandatk();
                if (Attacks == 1)
                {
                    Shoot();
                    timerstop = 0f;
                }
                if (Attacks == 2)
                {
                    Swing();
                    timerstop = 0f;
                }
                if (Attacks == 3)
                {
                    Swing2Shockwave();
                    timerstop = 0f;
                }
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
                animator.SetBool("IsWalking", true);
            }
            else if (direction < 0f)
            {
                direction = direction * (-1);
                animator.SetBool("IsWalking", true);
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
        return rand.Next(1,4);
    }

    private void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x * direction, 10f);
        animator.SetBool("IsJumping", true);
    }

    private void Shoot()
    {
        bulletinstance =  Instantiate(bullet);
        bulletinstance.transform.position = new Vector3(transform.position.x, transform.position.y - 2f, transform.position.z);
        // ChatGPT Prompt: wie kann ich machen das ein gameobject mit einem anderen spezifischen Gameobject NICHT interagiert?
        Physics2D.IgnoreCollision(
        bulletinstance.GetComponent<Collider2D>(),
        boss.GetComponent<Collider2D>()
        );
        // Ende ChatGPT
        bulletinstance.SetActive(true);
        animator.SetBool("IsAtacking", true);
    }

    private void Swing()
    {
        timerAtk1 = 0f;
        Atk1.SetActive(true);
        animator.SetBool("IsAttcking2", true);
    }

    private void Swing2Shockwave()
    {
        timerAtk2 = 0f;
        timerSchockwave = 0f;
        Atk2Shockwave.SetActive(true);   
        schockwave = true;
        animator.SetBool("IsAttcking2", true);
    }

    public void Die()
    {
        if (hp <= 0)
        {
            hpcanvas.SetActive(false);
            boss.SetActive(false);
            Geld_anzeige.Instance.AddMoney(1000);
            hpactive = true;
            animator.SetBool("IsDead", true);
            
        }
    }
}
