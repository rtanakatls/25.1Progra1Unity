using UnityEngine;

public class BossPhase1 : IStrategy
{
    private Rigidbody rb;

    public BossPhase1(Rigidbody rb)
    {
        this.rb = rb;
    }

    public void Execute()
    {
        rb.linearVelocity = rb.transform.forward;
    }
}
