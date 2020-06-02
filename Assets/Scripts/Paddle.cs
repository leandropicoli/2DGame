using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    public float paddleSpeed = 5.0f;
    public float xMin = -7.5f;
    public float xMax = 7.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PaddleMovement();
    }

    private void PaddleMovement()
    {
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, xMin, xMax), transform.position.y);

        if (Input.GetAxisRaw("Horizontal") > 0.01f)
        {
            transform.Translate(Vector2.right * paddleSpeed * Time.deltaTime);
        }

        if (Input.GetAxisRaw("Horizontal") < -0.01f)
        {
            transform.Translate(Vector2.left * paddleSpeed * Time.deltaTime);
        }

    }
}
