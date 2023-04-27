using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    
    public void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("Pelota"))
        {
            Destroy(gameObject);
        }

    }



}
