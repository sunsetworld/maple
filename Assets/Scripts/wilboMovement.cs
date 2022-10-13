using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

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
        CheckForMovement();
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

    private void CheckForMovement()
    {
        if (_hasJumped && !_timer.GetTimesUp())
        {
            if (_myRigidbody.velocity.y == 0 && _myRigidbody.velocity.x == 0)
            {
                _timer.TimesUp();
            }
        }
    }


    void OnRestart()
    {
        Debug.Log("This should restart the game.");
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);

    }

    void OnQuit()
    {
        Debug.Log("This should quit the game.");
        Application.Quit();
    }

}
