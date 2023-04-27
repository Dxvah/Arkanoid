using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float mSpeed = 5f;
    Rigidbody2D rBody;
    public float lMovement = 7f;
    Vector2 startPosition;

    private void Start()
    {
        startPosition = transform.position;
        rBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 move = new Vector2(horizontal, 0.0f);
        rBody.velocity = move * 5f;
       

    }
    public void ResetPlayer()
    {
        transform.position = startPosition;
        rBody.velocity = Vector2.zero;
    }
}
