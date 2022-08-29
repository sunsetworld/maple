using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineObj : MonoBehaviour
{
    [SerializeField] int boostAmount = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<wilboMovement>().wilboJump(boostAmount);
        }
    }


}
