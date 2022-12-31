using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Spawner Spawner;
    public float speed = 5f;
    public float launch;
    public float initialSpeed = 10f;
    public int Winkel1 = 1;
    public int Winkel2 = 1;
    public int Winkel3 = 1;
    public int Winkel4 = 1;
    public int Winkel5 = 1;
    private Rigidbody2D rb;
    public int Life = 3;
    public Text lifepoints;
    public Text Scorepoints;
    public Text MultiPoints;
    public static int score = 0;
    public static int multi = 0;
    public AudioClip beruehren;
    private AudioSource Source;
    public AudioClip dmg;
    public int AnzahlLastBrick = 0;
    private void Start()
    {
        Source= GetComponent<AudioSource>();
    }
    public void Update()
    {
        {
            lifepoints.text = Life.ToString();
        }
        {
            Scorepoints.text = score.ToString();
        }
        {
            MultiPoints.text = multi.ToString();
        }
        
        if (rb.velocity == Vector2.zero)
        {            
            if (Input.GetKeyDown(KeyCode.Space) == true)
            {
                LaunchBall();
            }
        }
        if (AnzahlLastBrick == Spawner.Anzahlxy)
        {
            SceneManager.LoadScene("Win");
        }
    }  
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void LaunchBall()
    {
        rb.velocity = Vector3.up * initialSpeed;
    }
    private void BallReset()
    {
        Vector3 Nballpostion = new Vector3(0, -2, 0);
        transform.position = Nballpostion;
        rb.velocity = Vector3.zero;
    }
    private void Ballwinkel1()
    {
        rb.velocity = Vector3.right * Winkel1 + (Vector3.up * initialSpeed);
        rb.velocity.Normalize();
    }
    private void Ballwinkel2()
    {
        rb.velocity = Vector3.right * Winkel2 + (Vector3.up * initialSpeed);
        rb.velocity.Normalize();
    }
    private void Ballwinkel3()
    {
        rb.velocity = Vector3.right * Winkel3 + (Vector3.up * initialSpeed);
        rb.velocity.Normalize();
    }
    private void Ballwinkel4()
    {
        rb.velocity = Vector3.right * Winkel4 + (Vector3.up * initialSpeed);
        rb.velocity.Normalize();
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.gameObject.CompareTag("borderDown"))
        {
            Source.clip = beruehren;
            Source.Play();
        }
        if (col.gameObject.CompareTag("borderDown"))
        {
            BallReset();
            multi = 0;
            Source.clip = dmg;
            Source.Play();
            Life += -1;           
             if( Life == 0 )
            {
                SceneManager.LoadScene("Death");
            }
            if (rb.velocity == Vector2.zero)
            {                
                if (Input.GetKeyDown(KeyCode.Space) == true)
                {
                    LaunchBall();
                }
            }
        }
        if (col.gameObject.CompareTag("Player1"))
        {
            Ballwinkel1();
            multi = 0;
        }
        if (col.gameObject.CompareTag("Player2"))
        {
            Ballwinkel2();
            multi = 0;
        }
        if (col.gameObject.CompareTag("Player3"))
        {
            Ballwinkel3();
            multi = 0;
        }
        if (col.gameObject.CompareTag("Player4"))
        {
            Ballwinkel4();
            multi = 0;
        }
        if (col.gameObject.CompareTag("brickPrepab"))
        {
            AnzahlLastBrick++;
            multi += 1;
            score += 50 * multi;
        }       
    }
}