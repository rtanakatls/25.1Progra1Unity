using UnityEngine;
using TMPro;

public class TimerText : MonoBehaviour
{
    private TextMeshProUGUI timerText;

    private void Awake()
    {
        timerText = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        GameManagerImproved.Instance.OnTimerChanged += OnTimerChanged;
    }


    private void OnTimerChanged(float timer)
    {
        timerText.text = $"Time: {timer}";
    }


    private void OnDestroy()
    {
        if (GameManagerImproved.Instance != null)
        {
            GameManagerImproved.Instance.OnTimerChanged -= OnTimerChanged;
        }
    }
}
