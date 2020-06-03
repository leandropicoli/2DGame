using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int boxQuantity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseBoxQuantity()
    {
        boxQuantity++;
    }

    public void DecreaseBoxQuantity()
    {
        boxQuantity--;

        if(boxQuantity <= 0)
        {
            if(SceneManager.GetActiveScene().buildIndex + 1 < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            } else 
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
