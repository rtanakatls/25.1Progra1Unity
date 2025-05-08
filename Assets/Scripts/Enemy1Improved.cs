using UnityEngine;

public class Enemy1Improved : MonoBehaviour
{
    private float speed;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        GameManagerImproved.Instance.OnProgressionChanged += OnProgressionChanged;
    }

    private void OnProgressionChanged(int progression)
    {
        speed = progression;
    }

    void Update()
    {
        rb.linearVelocity = new Vector3(0, 0, speed);
    }

    private void OnDestroy()
    {
        if (GameManagerImproved.Instance != null)
        {
            GameManagerImproved.Instance.OnProgressionChanged -= OnProgressionChanged;
        }
    }
}
