using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PunkteAnzeige : MonoBehaviour
{
    public Ball script;
    public Text Scorepoint;

    public static int Score1 = 0;
    public static int Multi1 = 0;

    private void Start()
    {
       
    }
     void Update()
    {
        int Score1 = Ball.score;
        Scorepoint.text = Score1.ToString();
    }
    

    
    

    
}
