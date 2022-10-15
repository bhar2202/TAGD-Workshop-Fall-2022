using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class deleteAndAddScore : MonoBehaviour
{

     

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hit");

        if(collision.collider.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt("Gold", PlayerPrefs.GetInt("Gold") + 1);
            Destroy(gameObject);
        }
    }
}
