using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float vertical;
    public float horizontal;
    public float speed = 5f;
    private Rigidbody2D rb;
    public int Absprungwinkel = 1;
    public float linkeGrenze = -2.5f;
    public float rechteGrenze = 2.5f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        Vector2 Movement = Vector2.right * horizontal * speed * Time.deltaTime;
        transform.Translate(Movement);
        Vector2 position = transform.position;
        position.x = Mathf.Clamp(position.x, linkeGrenze, rechteGrenze);
        transform.position = position;
    }
}
