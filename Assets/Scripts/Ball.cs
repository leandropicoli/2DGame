using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool gameStarted;
    public float directionY;
    public float directionX;
    public Rigidbody2D oRigidbody2d;
    public AudioSource ballSound;
    // Start is called before the first frame update
    void Start()
    {
        gameStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TrhrowBall();
        }
    }

    private void TrhrowBall()
    {
        if(!gameStarted)
        {
            oRigidbody2d.velocity = new Vector2(directionX, directionY);
            gameStarted = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        ballSound.Play();
    }
}
