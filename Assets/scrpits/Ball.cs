using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
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
    public int score = 0;
    public int multi = 0;
    
    
    // Start is called before the first frame update
    private void Update()
    {
        {
            lifepoints.text = Life.ToString();
        }
        {
            Scorepoints.text = score.ToString();
        }
        if (rb.velocity == Vector2.zero)
        {
             
            if (Input.GetKeyDown(KeyCode.Space) == true)
            {
                LaunchBall();
            }
        }
    }

    void Start()
    {
        
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
    private void Ballwinkel5()
    {
        rb.velocity = Vector3.right * Winkel5 + (Vector3.up * initialSpeed);
        rb.velocity.Normalize();
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("borderDown"))
        {
            print(multi);
            BallReset();
            multi = 0;


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
            print(multi);
            Ballwinkel1();
            multi = 0;
        }
        if (col.gameObject.CompareTag("Player2"))
        {
            print(multi);
            Ballwinkel2();
            multi = 0;
        }
        if (col.gameObject.CompareTag("Player3"))
        {
            print(multi);
            Ballwinkel3();
            multi = 0;
        }
        if (col.gameObject.CompareTag("Player4"))
        {
            print(multi);
            Ballwinkel4();
            multi = 0;
        }
        if (col.gameObject.CompareTag("Player5"))
        {
            print(multi);
            Ballwinkel5();
            multi = 0;
        }
        if (col.gameObject.CompareTag("brickPrepab"))
        {
            multi += 1;
            score += 50 * multi;
            

            print("score is " + score);
        }
        

    }

}