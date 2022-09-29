using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class scoreSystem : MonoBehaviour
{
    private Timer _timer;
    Rigidbody2D myRigidbody;
    float score;
    // Start is called before the first frame update
    void Start()
    {
        _timer = GetComponent<Timer>();
        myRigidbody = GetComponent<Rigidbody2D>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        AddScore();
    }

    void AddScore()
    {
        if (!_timer.GetTimesUp())
        {
            if (myRigidbody.velocity.x > 0)
            {
                score += myRigidbody.velocity.x * Time.deltaTime;
                Debug.Log(score);
            }
        }


    }

    public float GetScore()
    {
        return score;
    }


}
