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

    public Animator HUDTxt;

    public bool wilboHasStopped = false;

    [SerializeField] GameObject GameOverHUD;
    bool hasGameOverHUDSpawned = false;
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
        GameOver();
    }

    void OnJump(InputValue action)
    {
        if (action.isPressed)
        {
            if (!_timer.GetTimesUp())
            {
                if (!_hasJumped)
                {
                    wilboJump(1);
                    _hasJumped = true;
                }
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
        if (_timer.GetTimesUp())
        {
            if (!hasGameOverHUDSpawned)
            {
                Instantiate(GameOverHUD);
                hasGameOverHUDSpawned = true;
            }
        }
    }

    public bool GetHasJumped()
    {
        return _hasJumped;
    }

    void checkForMovement()
    {

    }


}
