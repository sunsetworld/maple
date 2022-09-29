using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = Unity.Mathematics.Random;

public class startingPoint : MonoBehaviour
{
    [SerializeField] private GameObject wilbo;

    private float _wilboNum;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(wilbo, transform.position, quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
