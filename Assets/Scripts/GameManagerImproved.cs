using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerImproved : MonoBehaviour
{
    private static GameManagerImproved instance;
    
    public static GameManagerImproved Instance { get { return instance; } }

    public event Action<int> OnProgressionChanged;
    public event Action<float> OnTimerChanged;

    private float timer;
    private int progression;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        OnTimerChanged?.Invoke(timer);
        if (timer >= progression)
        {
            progression++;
            OnProgressionChanged?.Invoke(progression);
        }
    }
}
