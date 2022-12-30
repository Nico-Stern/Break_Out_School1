using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using TMPro;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.SocialPlatforms;

public class Spawner : MonoBehaviour
{
    public GameObject brickPrefab;
    public BorderBrick Border;
    public int xbricks = 1;
    public int ybricks = 1;
    public float cDistance = 0.5f;
    public int Anzahlxy = 0;
    public Brick Brick;
    public void Start()
    {
        for (int i = 0; i < ybricks; i++)
        {
            for (int j = 0; j < xbricks; j++)
            {
                Instantiate(brickPrefab, transform.position, Quaternion.identity);
                transform.position += Vector3.right;
            }
            transform.position += Vector3.down;

            transform.position += Vector3.left * xbricks;

            transform.position += Vector3.down * cDistance;           
        } 
        Anzahlxy = xbricks * ybricks;       
    }    
}