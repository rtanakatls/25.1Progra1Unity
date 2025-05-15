using UnityEngine;

public class BossPhase2 : IStrategy
{
    private Transform transform;

    public BossPhase2(Transform transform, Rigidbody rb)
    {
        this.transform = transform;
        rb.linearVelocity = Vector3.zero;
    }

    public void Execute()
    {
        transform.localScale += Vector3.one * Time.deltaTime;
    }
}
