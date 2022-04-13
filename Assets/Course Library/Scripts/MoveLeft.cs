using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30f;
    private PlayerController playerControllerScript;
    private float leftBound = -15;

    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            if (playerControllerScript.doubleSpeed)
            {
                transform.Translate(Vector3.left * (speed * 2) * Time.deltaTime);
            }
            else
            { 
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }

        }
        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }

    }
}
