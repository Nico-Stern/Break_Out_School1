using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Spawner : MonoBehaviour
{
    public GameObject brickPrefab;
    public BorderBrick Border;

    public int xbricks = 1;
    public int ybricks = 1;
    public float cDistance = 0.5f;




    private void Start()
    {
        
        Debug.Log(Border.Level);
        
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
        int Anzahl = xbricks * ybricks;
        
    }
    
}