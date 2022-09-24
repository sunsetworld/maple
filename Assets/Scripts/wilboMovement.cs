using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class wilboMovement : MonoBehaviour
{
    private Rigidbody2D _myRigidbody;
    [SerializeField] private GameObject wilbo;

    [SerializeField] ParticleSystem myParticleSystem;

    public Vector2 velocity;

    private Timer _timer;
    // Start is called before the first frame update
    void Start()
    {
        _myRigidbody = GetComponent<Rigidbody2D>();
        _timer = GetComponent<Timer>();

    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(_myRigidbody.velocity );
    }

    void OnJump(InputValue action)
    {
        if (action.isPressed)
        {
            // Instantiate(wilbo, transform.position, Quaternion.identity);
            wilboJump(1);
        }
    }

    public void wilboJump(int amount)
    {
        _myRigidbody.velocity = _myRigidbody.velocity + velocity * amount;
        myParticleSystem.Play();

    }
   
    
    
}
