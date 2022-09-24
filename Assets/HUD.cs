using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    Timer _timer;
    

    [SerializeField] TextMeshProUGUI _timerTxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timer = FindObjectOfType<Timer>();
        if (_timer != null)
        {
            _timerTxt.text = _timer.GetTimer().ToString("F2");
        }
        
    }
}
