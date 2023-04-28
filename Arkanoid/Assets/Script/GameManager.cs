using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int vidas = 3;
    public Canvas retryMenu;

    public void PerderVidas()
    {
        vidas--;
        if (vidas <= 0)
        {
            retryMenu.gameObject.SetActive(true);
        }
        else
        {
            ResetLevel();
        }

    }
    public void ResetLevel()
    {

        FindObjectOfType<BallBehaviour>().ResetBall();
        FindObjectOfType<PlayerMovement>().ResetPlayer();
        

        
    }



}
