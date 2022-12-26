using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BorderBrick : MonoBehaviour
{
    public Spawner Spawner;
    private int nextscene;
    
    public int AnzahlLastBrick = 0;
    private void Start()
    {
        
    }
    

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("brickPrepab"))
        {
            AnzahlLastBrick++;
            print("Bricks = " + AnzahlLastBrick);
        }   
    }
    public void Update()
    {
        if(AnzahlLastBrick== Spawner.Anzahlxy)
        {
            SceneManager.LoadScene("Win");
        }
    }
        
    
}
