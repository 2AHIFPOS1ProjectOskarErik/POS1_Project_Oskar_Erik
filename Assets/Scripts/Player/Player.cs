using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using JetBrains.Annotations;
using System.Threading;
using System;
using Unity.VisualScripting;

public class Movement : MonoBehaviour
{

    Camera camera;
    Rigidbody2D rb;
    BoxCollider2D collider2D;
    bool canjump;
    float timer;
    public Dialog1 dialog1;
    public bool canmove = true;
    bool dialogfin = false;
    public GameObject waffe1;
    SpriteRenderer sr;
    public double hp = 5;
    
    //start tutorialvideo code:
    [SerializeField] private Animator _animation;
    //ende tutorialvideo code:

    void Start()
    {
        camera = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        rb.freezeRotation = true;
        collider2D = GetComponent<BoxCollider2D>();
        collider2D.offset = new Vector2(-0.6170132f, -0.03940761f);
    }

    // Update is called once per frame

    void Update()
    {


        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            canjump = false;
        }
        Crouch();
        Move();
        Jump();
        if (hp <= 0)
        {
            Die();
        }
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
                camera.orthographicSize = 3f;
                camera.transform.position = new Vector3(3f, -2f, -10f);
                dialogfin = dialog1.RunDialog();
            }
            if (dialogfin == true)
            {
                canmove = true;
                camera.orthographicSize = 5f;
                camera.transform.position = new Vector3(0f, 0f, -10f);
                //dialog1.text.transform.position = new Vector2(650, -300);
            }

        }

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



    }

    public void Move()
    {
        float move = 0;
        if (Keyboard.current.dKey.isPressed && canmove == true)
        {
            _animation.SetBool("IsRunning", true);
            sr.flipX = false;
            move = 1;
        }
        if (Keyboard.current.aKey.isPressed && canmove == true)
        {
            _animation.SetBool("IsRunning", true);
            move = -1;
            sr.flipX = true;
        }

        if (Keyboard.current.dKey.isPressed == false && Keyboard.current.aKey.isPressed == false)
        {
            _animation.SetBool("IsRunning", false);
        }
        rb.linearVelocity = new Vector2(move * 5f, rb.linearVelocity.y);
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
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 8f);
            canjump = false;
        }
    }

    public void TakeDamage()
    {
        hp -= 0.5;
    }

    public void Die()
    {
        
    }
}
