using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;
using System.Collections;
public class Movement : MonoBehaviour
{
    public double dmg = 2;
    bool strengthActive = false;
    Camera camera;
    Rigidbody2D rb;
    BoxCollider2D collider2D;
    bool canjump;
    float timer;
    public Dialog1 dialog1;
    public bool canmove = true;
    bool dialogfin = false;
    public GameObject waffe1;
    public GameObject upslash;
    public GameObject player;
    private GameObject GateBoss;
    private GameObject GateBoss2;
    GameObject enemyfollow;
    private GameObject MiniBoss;
    private MiniBoss miniBossCode;
    private GameObject boss;
    private Boss bossCode;
    SpriteRenderer sr;
    public double hp = 5;
    public double maxHP = 5;
    public HPAnzeige HPAnzeige;
    float timerdmg;
    float timeratkcool;
    float timeratk;
    public List<Vector2>  Übergänge; // Idx 0 = Tutorial -> Schloss, Idx 1 = Schloss -> Tuturial, etc. 
    public List<Vector2> Checkpoints;
    public int current_Checkpoint = 0;
    public static Movement instance;
    private float oldy;
    public CameraFollow camerafollow;
    bool gefangen = false;
    bool falleBenutzt = false;
    //start tutorialvideo code:
    [SerializeField] private Animator _animation;    private Animator _animation_jump;
    Animator animator;
    //ende tutorialvideo code:



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    //start chatgpt, prompt: wenn ich ein dont destroy on load habe und die scene zu einer anderen wechsel wo ein gameobject existiert was es in der ersten scene nicht gab welches ich im code benötige, wie kann ich das übergeben?
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        enemyfollow = GameObject.Find("Enemy Follow");
        // Ende Chatgpt
        GateBoss = GameObject.Find("GateBoss");
        GateBoss2 = GameObject.Find("GateBoss 2");
        MiniBoss = GameObject.Find("Mini Boss");
        boss = GameObject.Find("Boss");
        try
        {
            miniBossCode = MiniBoss.GetComponent<MiniBoss>();
        }
        catch { }
        try
        {
            bossCode = boss.GetComponent<Boss>();
        }
        catch { }
    }



    void Start()
    {

        maxHP = 5;
        DontDestroyOnLoad(player); // von ChatGPT
        Übergänge = new List<Vector2>();
        Übergänge.Add(new Vector2(7.5f, 1.8f));
        Übergänge.Add(new Vector2(-96.6f, 11.3f));
        Übergänge.Add(new Vector2(-30.1f, 1.9f));
        Übergänge.Add(new Vector2(0f, 0f));
        Übergänge.Add(new Vector2(-54.88f, -1.7f));
        //------------------------------------
        Übergänge.Add(new Vector2(-0.61f, 19.91f));
        Übergänge.Add(new Vector2(-18.18f, 1f));
        //------------------------------------
        Checkpoints = new List<Vector2>();
        
        Checkpoints.Add(new Vector2(-15.12f, -1.76f));
        Checkpoints.Add(new Vector2(-1.64f, -1.04f));
        camera = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        
       
        collider2D = GetComponent<BoxCollider2D>();
        collider2D.offset = new Vector2(-0.6170132f, -0.03940761f);
        rb.freezeRotation = true;
        _animation_jump = GetComponent<Animator>();
        camera.orthographicSize = 6f;
    }

    // Update is called once per frame

    void Update()
    {

        if (gefangen)
            return;
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            UseHealthPotion();
        }

        if (Keyboard.current.tKey.wasPressedThisFrame)
        {
            UseStrengthPotion();
        }
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Attack();
        }
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            UpAttack();
        }
        if (timeratk >= 0.5)
        {
            waffe1.SetActive(false);
            upslash.SetActive(false);
        }
        Crouch();
        Move();
        Jump();
        if (hp <= 0)
        {
            Die();
        }
        timerdmg += Time.deltaTime;
        timeratkcool += Time.deltaTime;
        timeratk += Time.deltaTime;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            canjump = true;
            timer = 0;
        }
        else if (collision.gameObject.CompareTag("Wall"))
        {
            canjump = true;
            timer += Time.deltaTime;
            if (timer >= 1f)
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, -6f);
                canjump = false;
            }
        }
        else
        {
            canjump = false;
        }


        if (collision.gameObject.CompareTag("NPC John"))
        {
            if (collision.gameObject.CompareTag("Floor"))
                canjump = true;

            if (Keyboard.current.eKey.isPressed && dialogfin == false)
            {
                canmove = false;
                camera.orthographicSize = 4f;
                camerafollow.offset = new Vector3(1f, 2f, -10f);
                dialogfin = dialog1.RunDialog();
            }
            if (dialogfin == true)
            {
                canmove = true;
                camera.orthographicSize = 6f;
                camerafollow.offset = new Vector3(0f, 4f, -10f);
            }

        }

        if (collision.gameObject.CompareTag("Simple Enemy") || collision.gameObject.CompareTag("EnemyFollow") || collision.gameObject.CompareTag("Falle"))
        {
            TakeDamage();
        }
        if (collision.gameObject.CompareTag("baerfalle") && !falleBenutzt)
        {
            falleBenutzt = true;

            TakeDamage();
            StartCoroutine(Falle());
        }
        if (collision.gameObject.CompareTag("Line of Sight"))
        {
            EnemyFollow enemyfollowscript = enemyfollow.GetComponent<EnemyFollow>();
            enemyfollowscript.Follow();
        }

        if (collision.gameObject.CompareTag("Seil") && Keyboard.current.eKey.isPressed)
        {
            SceneManager.LoadScene("Schloss");
            transform.position = Übergänge[4];
        }

        if (collision.gameObject.CompareTag("Brunnen") && Keyboard.current.eKey.isPressed)
        {
            SceneManager.LoadScene("Dungeon");
            current_Checkpoint = 1;
            transform.position = Übergänge[3];
        }
        if (collision.gameObject.CompareTag("Shop") && Keyboard.current.eKey.isPressed)
        {
            SceneManager.LoadScene("Shop");
            transform.position = Übergänge[3];
        }

        if (collision.gameObject.CompareTag("MiniBossFight"))
        {
            GateBoss.GetComponent<Collider2D>().enabled = true;
            GateBoss.GetComponent<SpriteRenderer>().enabled = true;
            GateBoss2.GetComponent<Collider2D>().enabled = true;
            GateBoss2.GetComponent<SpriteRenderer>().enabled = true;
            miniBossCode.bossstart = true;  
        }
        if (collision.gameObject.CompareTag("Bossfight"))
        {
            GateBoss.GetComponent<Collider2D>().enabled = true;
            GateBoss.GetComponent<SpriteRenderer>().enabled = true;
            GateBoss2.GetComponent<Collider2D>().enabled = true;
            GateBoss2.GetComponent<SpriteRenderer>().enabled = true;
            bossCode.bossstart = true;

        }

    }
    IEnumerator Falle()
    {
        gefangen = true;

        yield return new WaitForSeconds(5);

        gefangen = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("NPC John"))
        {

            if (collision.gameObject.CompareTag("Floor"))

                canjump = true;
            dialog1.text.text = "Druecke \"E\" um mit mir zu Interagieren!";
            dialogfin = false;
        }

        if (collision.gameObject.CompareTag("Simple Enemy") || collision.gameObject.CompareTag("EnemyFollow") || collision.gameObject.CompareTag("Mini Boss") || collision.gameObject.CompareTag("Boss"))
        {
            TakeDamage();
        }


        if (collision.gameObject.CompareTag("Übergang TutSchloss"))
        {
            SceneManager.LoadScene("Schloss");
            transform.position = Übergänge[0];
        }


        if (collision.gameObject.CompareTag("Übergang SchlossTut"))
        {
            SceneManager.LoadScene("Tutorial");
            transform.position = Übergänge[1];
        }

        if (collision.gameObject.CompareTag("Brunnen") && Keyboard.current.eKey.isPressed)
        {
            SceneManager.LoadScene("Dungeon");
            current_Checkpoint = 1;
            transform.position = Übergänge[3];
        }
        if (collision.gameObject.CompareTag("Seil") && Keyboard.current.eKey.isPressed)
        {
            SceneManager.LoadScene("Schloss");
            transform.position = Übergänge[4];
        }

        if (collision.gameObject.CompareTag("MiniBossFight"))
        {
            canjump = true;
            MiniBoss.GetComponent<Collider2D>().enabled = true;
            MiniBoss.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (collision.gameObject.CompareTag("Bossfight"))
        {
            GateBoss.GetComponent<Collider2D>().enabled = true;
            GateBoss.GetComponent<SpriteRenderer>().enabled = true;
            GateBoss2.GetComponent<Collider2D>().enabled = true;
            GateBoss2.GetComponent<SpriteRenderer>().enabled = true;
            bossCode.bossstart = true;

        }
        if (collision.gameObject.CompareTag("Übergang Caves"))
        {
            SceneManager.LoadScene("Crystal Cave");
            player.transform.position = new Vector2(0f, 0f);
        }
    }



    public void Move()
    {
        float move = 0;
        if (Keyboard.current.dKey.isPressed && canmove == true)
        {
            _animation.SetBool("IsRunning", true);
            transform.localScale = new Vector3(1, 1, 1);
            move = 1;
        }
        if (Keyboard.current.aKey.isPressed && canmove == true)
        {
            _animation.SetBool("IsRunning", true);
            move = -1;
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (Keyboard.current.dKey.isPressed == false && Keyboard.current.aKey.isPressed == false)
        {
            _animation.SetBool("IsRunning", false);
        }
        rb.linearVelocity = new Vector2(move * 8f, rb.linearVelocity.y);
    }

    public void Crouch()
    {
        if (Keyboard.current.sKey.isPressed && canmove == true)
        {
            collider2D.size = new Vector2(1f, 1f);
            collider2D.offset = new Vector2(0f, -0.5f);
            
            
        }
        else
        {
            collider2D.size = new Vector2(1f, 2f);
            collider2D.offset = new Vector2(0f, 0f);
        }
    }
    public void Jump()
    {
        if (Keyboard.current.spaceKey.isPressed && canjump == true && canmove == true)
        {
            _animation_jump.SetBool("IsJumping", true);
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 8f);
            canjump = false;

        }
        if (canjump == true)
        {
            _animation_jump.SetBool("IsJumping", false);
        }
    }

    public void TakeDamage()
    {
        if (timerdmg >= 1f)
        {
            hp -= 1;
            HPAnzeige.UpdateHP();
            timerdmg = 0f;
        }

    }



    public void Die()
    {
        SceneManager.LoadScene("Deathscreen");
        hp = maxHP;
        player.transform.position = Checkpoints[current_Checkpoint];
    }

    public void Attack()
    {
        if (timeratkcool >= 1f)
        {
            timeratk = 0;
            waffe1.SetActive(true);
            timeratkcool = 0;
        }
        
    }

    public void UpAttack()
    {
        if (timeratkcool >= 1f)
        {
            timeratk = 0;
            upslash.SetActive(true);
            timeratkcool = 0;
        }
    }

    void UseHealthPotion()
    {
        int healthPotions = PlayerPrefs.GetInt("Health", 0);

        if (healthPotions > 0)
        {
            healthPotions--;

            PlayerPrefs.SetInt("Health", healthPotions);

            hp += 2;

            if (hp > maxHP)
                hp = maxHP;

            HPAnzeige.UpdateHP();

            InventoryUI.Instance.UpdateTexts();

            Debug.Log("Health Potion benutzt!");
        }
    }
    void UseStrengthPotion()
    {
        int strengthPotions = PlayerPrefs.GetInt("Strength", 0);

        if (strengthPotions > 0 && !strengthActive)
        {
            strengthPotions--;
            PlayerPrefs.SetInt("Strength", strengthPotions);

            dmg *= 2;

            strengthActive = true;

            InventoryUI.Instance.UpdateTexts();

            StartCoroutine(RemoveStrengthBuff());

            Debug.Log("Strength Potion benutzt!");
        }
    }
    //ChatGPT code anfang
    IEnumerator RemoveStrengthBuff()
    {
        yield return new WaitForSeconds(120f);

        dmg /= 2;

        strengthActive = false;

        Debug.Log("Strength Buff beendet!");
    }
    //ChatGPT code ende
}
