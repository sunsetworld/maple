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
    
    bool _hasJumped;
    
    public bool wilboHasStopped = false;
    // Start is called before the first frame update
    void Start()
    {
        _myRigidbody = GetComponent<Rigidbody2D>();
        _timer = GetComponent<Timer>();
        _hasJumped = false;

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
            if (!_hasJumped)
            {
                wilboJump(1);
                _hasJumped = true;
            }
        }
    }

    public void wilboJump(int amount)
    {
        if (!_timer.GetTimesUp())
        {
            _myRigidbody.velocity = _myRigidbody.velocity + velocity * amount;
            myParticleSystem.Play();
        }

    }
    

    public void GameOver()
    {
        
    }
   
    
    
}
