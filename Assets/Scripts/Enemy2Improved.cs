using UnityEngine;

public class Enemy2Improved : Enemy
{

    private void Start()
    {
        GameManagerImproved.Instance.OnProgressionChanged += OnProgressionChanged;
    }

    private void OnProgressionChanged(int progression)
    {
        transform.localScale = progression * Vector3.one;
    }


    private void OnDestroy()
    {
        if (GameManagerImproved.Instance != null)
        {
            GameManagerImproved.Instance.OnProgressionChanged -= OnProgressionChanged;
        }
    }
}
