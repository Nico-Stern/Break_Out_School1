using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BorderBrick : MonoBehaviour
{
    private int nextscene;
    
    int AnzahlLastBrick = 0;
    private void Start()
    {
        nextscene = SceneManager.GetActiveScene().buildIndex + 1;       
    }
    

    
    public int Level = 1;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("brickPrepab"))
        { AnzahlLastBrick++;}
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("brickPrepab"))
        { AnzahlLastBrick--;
                  
        }
        
        {
            if (AnzahlLastBrick <= 0)
            {
                SceneManager.LoadScene("Win");               
            }
        }
    }   
}
