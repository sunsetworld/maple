using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float gameTime = 60;

    private bool _timesUp;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<wilboMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_timesUp)
        {        
            gameTime -= Time.deltaTime;
            Debug.Log("Game time " + gameTime);

        }

        checkForTimesUp();
        
        Debug.Log("Times up: " + _timesUp);
                
    }

    void checkForTimesUp()
    {
        if (gameTime <= 0)
        {
            _timesUp = true;
        }

        else
        {
           _timesUp = false;
        }
    }



    public bool GetTimesUp()
    {
        return _timesUp;
    }

    public float GetTimer()
    {
        return gameTime;
    }

    public void TimesUp()
    {
        _timesUp = true;
    }


}
