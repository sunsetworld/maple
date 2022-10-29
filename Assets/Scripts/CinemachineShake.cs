using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineShake : MonoBehaviour
{

    private CinemachineVirtualCamera cinemachineCam;
    private float shakeTimer;
    private void Awake()
    {
        cinemachineCam = GetComponent<CinemachineVirtualCamera>();
    }

    public void Shake(float intensity, float timer)
    {
        CinemachineBasicMultiChannelPerlin cinemachineBMCP = cinemachineCam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        cinemachineBMCP.m_AmplitudeGain = intensity;
        shakeTimer = timer;

    }

    private void Update()
    {
        if (shakeTimer > 0)
        {
            shakeTimer -= Time.deltaTime;
            if (shakeTimer <= 0f)
            {
                CinemachineBasicMultiChannelPerlin cinemachineBMCP = cinemachineCam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
                cinemachineBMCP.m_AmplitudeGain = 0;
            }
        } 

    }
}
