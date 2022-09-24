using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float _gameTime;
    [SerializeField] float finishTime = 60;

    private bool _timesUp;
    // Start is called before the first frame update
    void Start()
    {
        _gameTime = 0;
        _timesUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_timesUp)
        {        
            _gameTime += Time.deltaTime;
            Debug.Log("Game time " + _gameTime.ToString());
            
        }

        checkForTimesUp();
    }

    void checkForTimesUp()
    {
        if (_gameTime >= finishTime)
        {
            _timesUp = true;
        }
        else if (_gameTime < finishTime)
        {
            _timesUp = false;
        }
    }

    bool GetTimesUp()
    {
        return _timesUp;
    }

    public float GetTimer()
    {
        return _gameTime;
    }
}
