using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreSystem : MonoBehaviour
{
    float score = 0;
    Rigidbody2D myRB;
    Timer timerSystem;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();    
        timerSystem = GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!timerSystem.GetTimesUp())
        {
            AddScore();
        }
    }

    private void AddScore()
    {

        if (myRB.velocity.x > 0)
        {
            score += myRB.velocity.x;
        }
        Debug.Log(score);
    }

    public float GetScore()
    {
        return score;
    }
}
