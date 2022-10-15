using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    [Range(1.0f, 25.0f)]
    float enemyMovement = 10.0f;
    public bool isFirst = false;

    [SerializeField]
    float endPos = -50.0f;

    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!isFirst)
        {
            transform.Translate(Vector3.back * Time.deltaTime * enemyMovement);
            if (transform.position.y != -2 && transform.position.z < endPos)
            {
                Destroy(gameObject);
            }
        }
        
        
        
    }
}
