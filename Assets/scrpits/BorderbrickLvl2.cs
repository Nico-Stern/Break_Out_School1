using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BorderbrickLvl2 : MonoBehaviour
{

    int AnzahlLastBrick = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("brickPrepab"))
        { AnzahlLastBrick++; }
        print(AnzahlLastBrick);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("brickPrepab"))
        { AnzahlLastBrick--; }
        print(AnzahlLastBrick);
        {
            if (AnzahlLastBrick <= 0)
            {
                SceneManager.LoadScene("Level_3");
            }
        }
    }
}
