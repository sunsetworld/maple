using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    Timer _timer;
    private wilboMovement _wilboMovement;
    scoreSystem _scoreSystem;

    [SerializeField] Animator _animator;

    [SerializeField] TextMeshProUGUI _timerTxt;
    [SerializeField] TextMeshProUGUI _scoreTxt;

    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        _timer = FindObjectOfType<Timer>();
        _scoreSystem = FindObjectOfType<scoreSystem>();
        if (_timer != null)
        {
            _timerTxt.text = _timer.GetTimer().ToString("F2");
        }

        if (_scoreSystem != null)
        {
            _scoreTxt.text = _scoreSystem.GetScore().ToString("F2");
        }
    }

}
