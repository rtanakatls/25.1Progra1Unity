using UnityEngine;
using TMPro;

public class ProgressionText : MonoBehaviour
{
    private TextMeshProUGUI progressionText;

    private void Awake()
    {
        progressionText= GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        GameManagerImproved.Instance.OnProgressionChanged += OnProgressionChanged;
    }


    private void OnProgressionChanged(int progression)
    {
        progressionText.text = $"Level: {progression}";
    }


    private void OnDestroy()
    {
        if (GameManagerImproved.Instance != null)
        {
            GameManagerImproved.Instance.OnProgressionChanged -= OnProgressionChanged;
        }
    }
}
