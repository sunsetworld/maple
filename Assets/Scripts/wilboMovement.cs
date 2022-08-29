using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class wilboMovement : MonoBehaviour
{
    private Rigidbody2D _myRigidbody;

    public Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        _myRigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            wilboJump();
        }
        Debug.Log(_myRigidbody.velocity );
    }

    void OnJump(InputValue action)
    {
        if (action.isPressed)
        {
            wilboJump();
        }
    }

    void wilboJump()
    {
        Debug.Log("Wilbo should jump.");
        _myRigidbody.velocity = _myRigidbody.velocity + velocity;

    }
    
    
}
