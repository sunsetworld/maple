using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineObj : MonoBehaviour
{
    [SerializeField] int boostAmount = 10;
    [SerializeField] bool canProvideDoubleJump;
    wilboMovement wilbo;
    private void OnCollisionEnter2D(Collision2D col)
    {
        /*
        if (col.gameObject.CompareTag("Player"))
        {
            wilbo = col.gameObject.GetComponent<wilboMovement>();
            if (wilbo != null)
            {
                wilbo.wilboJump(boostAmount);
                if (canProvideDoubleJump)
                {
                    wilbo.SetDoubleJump();
                }
            }

        }
        */

        if (col.gameObject.CompareTag("Player"))
        {
            wilbo = FindObjectOfType<wilboMovement>();
            if (wilbo != null)
            {
                wilbo.wilboJump(boostAmount);

                if (canProvideDoubleJump)
                {
                    wilbo.SetDoubleJump();
                }
            }
        }


    }


}
