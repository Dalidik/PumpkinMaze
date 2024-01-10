using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawn : MonoBehaviour
{
    public GameObject[] spawnPoint;
    public GameObject key;
    private Vector3 respawnPos;


     void Awake()
    {
      //  spawnPoint = GameObject.FindGameObjectsWithTag("SpawnPoint");
    }
    void Start()
    { 
       
       // respawnPos = key.transform.position;
        SpawnKey();
    }

    private void SpawnKey()
    {
        int spawn = Random.Range(0, spawnPoint.Length);
        GameObject.Instantiate(key, spawnPoint[spawn].transform.position, Quaternion.identity);
    }
}
