using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Vector3 startPos;

    [SerializeField]
    [Range(0f,15f)]
    private float SpeedMove = 3.0f;

    [SerializeField]
    [Range(0f, 25f)]
    private float UpForce = 5.0f;

    [SerializeField]
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //put player at starting position
        gameObject.transform.position = startPos;

    }

    

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("space pressed");
            rb.AddForce(new Vector3(0f, UpForce,0f));
        }

        transform.Translate(Vector3.forward * Time.deltaTime * SpeedMove);

    }

}
