using UnityEngine;

public class Enemy1 : MonoBehaviour, IObserver
{
    private float speed;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        GameManager.Instance.Attach(this);
    }

    public void Execute(ISubject subject)
    {
        if(subject is GameManager)
        {
            speed = ((GameManager)subject).Progression*10;
        }
    }

    void Update()
    {
        rb.linearVelocity = new Vector3(0, 0, speed);
    }
}
