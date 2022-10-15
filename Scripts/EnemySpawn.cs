using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;

    //[SerializeField]
    //private Vector3 spawnLoc;

    [SerializeField]
    [Range(0.1f, 5.0f)]
    private float spawnRate = 1.0f;
    private float currRate = 0.0f;
    private bool isSpawn = false;
    

    void Start()
    {
        isSpawn = false;
        //enemy = GameObject.Find("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        if (!isSpawn)
        {
            Instantiate(enemy, new Vector3(Random.Range(-5,5), Random.Range(5, 25), 50), new Quaternion(0,0,0,0));
            isSpawn = true;
        }

        currRate += Time.deltaTime;
        if (currRate > spawnRate)
        {
            isSpawn = false;
            currRate = 0.0f;//reset timer
        }
    }
}
