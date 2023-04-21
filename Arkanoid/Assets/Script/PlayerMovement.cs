using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float mSpeed = 5f;
    Rigidbody2D rBody;
    public float lMovement = 7f;

    private void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 move = new Vector2(horizontal, 0.0f);
        rBody.velocity = move * 5f;
        //Vector2 pPosition = transform.position;
        //pPosition.x = Mathf.Clamp(pPosition.x + mSpeed * Time.deltaTime, -lMovement, lMovement);

    }
}
