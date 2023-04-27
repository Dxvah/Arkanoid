using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallBehaviour : MonoBehaviour
{
    
    public float speed = 20f;
    [SerializeField]
    Rigidbody2D rBodyBall;
    public Vector2 velocity;
    Vector2 startPosition;
    
    void Start()
    {
        startPosition = transform.position;
        ResetBall();
    }
    public void OnCollisionEnter2D(Collision2D coll)
    {

        if(coll.gameObject.CompareTag("GameOver"))
        {
            FindObjectOfType<GameManager>().PerderVidas();

        }
    }
    public void ResetBall()
    {
        transform.position = startPosition;
        rBodyBall.velocity = Vector2.zero;
        velocity.x = Random.Range (-1f, 1f);
        velocity.y = 1;  
        rBodyBall.AddForce(velocity*speed); 
        
    }

}
