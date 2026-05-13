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
    float timerangriff;
    GameObject player;
    Sprite crouch;
    Sprite Normal;

    void Start()
    {
        camera = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        collider2D = GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame

    void Update()
    {
        timerangriff += Time.deltaTime;


        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            canjump = false;

        }
        if (Keyboard.current.sKey.isPressed && canmove == true)
        {
            Crouch();
        }

        Move();
        if (Keyboard.current.spaceKey.isPressed && canjump == true && canmove == true)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 8f);
            canjump = false;
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
                dialog1.text.transform.position = new Vector2(650, -300);
            }

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("NPC John"))
        {

            if (collision.gameObject.CompareTag("Floor"))

                canjump = true;
            dialog1.text.text = "Drücke \"E\" um mit mir zu Interagieren!";
            dialogfin = false;
        }



    }

    public void Move()
    {
        float move = 0;
        if (Keyboard.current.dKey.isPressed && canmove == true)
        {
            move = 1;
        }
        if (Keyboard.current.aKey.isPressed && canmove == true)
        {

            move = -1;

        }
        rb.linearVelocity = new Vector2(move * 5f, rb.linearVelocity.y);
    }

    public void Crouch()
    {
        collider2D.size = new Vector2(1f, 1f);
    }
}
