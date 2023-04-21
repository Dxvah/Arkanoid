using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField]
    Vector3 direction;
    [SerializeField]
    float speed = 6f;
    


    void Start()
    {
        direction.y = -1f;   
    }

    void Update()
    {
        transform.position += direction * Time.deltaTime * speed;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Bloque")
        {
            direction.x = Random.Range(1, -1f);
            direction.y = direction.y * -1f;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "Player")
        {
            direction.x = direction.x * 1;
            direction.y = Random.Range(1f, -1f);
        }
        else if (col.gameObject.tag == "Borde")
        {
            direction.x = direction.x * 1;
            direction.y = Random.Range(1f, 1f);
        }
    }
   void OnTriggerEnter2D(Collider2D collision)
   {
        Debug.Log("has perdido", gameObject);
        
   }

}
