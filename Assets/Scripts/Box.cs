using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject boxSound;

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<GameManager>().IncreaseBoxQuantity();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("Ball"))
        {
            FindObjectOfType<GameManager>().DecreaseBoxQuantity();
            Instantiate(boxSound, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
