using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    Timer _timer;
    startingPoint startingPoint;
    GameObject wilbo;
    float score;
    private wilboMovement _wilboMovement;

    [SerializeField] Animator _animator;

    [SerializeField] TextMeshProUGUI _timerTxt;
    [SerializeField] TextMeshProUGUI _scoreTxt;

    scoreSystem ScoreSystem;
    // Start is called before the first frame update
    void Start()
    {
        startingPoint = FindObjectOfType<startingPoint>();
        wilbo = startingPoint.GetWilboInGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer != null)
        {
            _timerTxt.text = _timer.GetTimer().ToString("F2");
        }
        score = wilbo.GetComponent<scoreSystem>().GetScore();

        if (ScoreSystem != null)
        {
            _scoreTxt.text = ScoreSystem.GetScore().ToString("F2");
        }

    }

}
