using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Vector3 startPos;

    [SerializeField]
    [Range(0f,15f)]
    private float forwardSpeed = 3.0f;

    [SerializeField]
    [Range(0f, 15f)]
    private float horizontalSpeed = 3.0f;

    [SerializeField]
    [Range(0f, 100f)]
    private float upForce = 5.0f;

    [SerializeField]
    [Range(0f, 1.0f)]
    private float jumpCooldown = 1.0f;

    [SerializeField]
    [Range(10f, 250f)]
    private float stopHeight = 15.0f;
    private float currJumpTime = 0.0f;

    [SerializeField]
    private Rigidbody rb;

    private bool isJumping;


    // Start is called before the first frame update
    void Start()
    {
        //put player at starting position
        gameObject.transform.position = startPos;
        rb = GetComponent<Rigidbody>();
        isJumping = false;

    }

    

    void Update()
    {
        
        if(transform.position.y > stopHeight)
        {
            rb.velocity = Vector3.zero;
        }
        if (Input.GetKeyUp(KeyCode.Space) && !isJumping )
        {
            //Debug.Log("space pressed");
            //rb.AddForce(Vector3.up * upForce);
            rb.velocity = Vector3.up * upForce;
            //transform.Translate(Vector3.up * Time.deltaTime * upForce);
            isJumping = true;
        }
        else if (isJumping)
        {
            currJumpTime += Time.deltaTime;
            if(currJumpTime > jumpCooldown)
            {
                isJumping = false;
                currJumpTime = 0.0f;//reset timer
            }
        }

        //transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed);

        if (Input.GetAxis("Horizontal") > 0.0f)
        {

            transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed);
            //rb.AddForce(Vector3.right * horizontalSpeed);

        } else if(Input.GetAxis("Horizontal") < 0.0f)
        {
            transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
            //rb.AddForce(Vector3.left * horizontalSpeed);
        }

    }


}
