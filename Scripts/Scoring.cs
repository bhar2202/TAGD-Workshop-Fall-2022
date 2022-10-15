using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoring : MonoBehaviour
{

    public TMP_Text gold;


    void Start()
    {
        //gold = GetComponent<TextMeshProGUI>();
    }
    

    // Update is called once per frame
    void Update()
    {
        gold.text = PlayerPrefs.GetInt("Gold") + "";
    }
}
