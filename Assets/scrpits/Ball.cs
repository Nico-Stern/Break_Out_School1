using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    
    // Start is called before the first frame update
    void Start()
    {
        LaunchBall();
    }

    // Update is called once per frame

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
        Vector3 Nballpostion = new Vector3(0, -2,0);
        rb.velocity = Vector3.zero;
        transform.position = Nballpostion;
    }

    private void Ballwinkel1()
    {
        rb.velocity = Vector3.right * Winkel1 + (Vector3.up * initialSpeed);
    }
    private void Ballwinkel2()
    {
        rb.velocity = Vector3.right * Winkel2 + (Vector3.up * initialSpeed);
    }
    private void Ballwinkel3()
    {
        rb.velocity = Vector3.right * Winkel3 + (Vector3.up * initialSpeed);
    }
    private void Ballwinkel4()
    {
        rb.velocity = Vector3.right * Winkel4 + (Vector3.up * initialSpeed);
    }
    private void Ballwinkel5()
    {
        rb.velocity = Vector3.right * Winkel5 + (Vector3.up * initialSpeed);
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("borderDown"))
        {
            BallReset();

            

            LaunchBall();
        }
        if (col.gameObject.CompareTag("Player1"))
        {
            Ballwinkel1();
        }
        if (col.gameObject.CompareTag("Player2"))
        {
            Ballwinkel2();
        }
        if (col.gameObject.CompareTag("Player3"))
        {
            Ballwinkel3();
        }
        if (col.gameObject.CompareTag("Player4"))
        {
            Ballwinkel4();
        }
        if (col.gameObject.CompareTag("Player5"))
        {
            Ballwinkel5();
        }

    }

}