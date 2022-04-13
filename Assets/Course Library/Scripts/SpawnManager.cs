using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    public float repeatRate = 2;
    private PlayerController playerControllerScript;
    void Start()
    {
        InvokeRepeating("SpawnOstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void SpawnOstacle()
    {
        int index = Random.Range(0, obstaclePrefab.Length);
        if (!playerControllerScript.gameOver) Instantiate(obstaclePrefab[index], spawnPos, obstaclePrefab[index].transform.rotation);
    }
}
