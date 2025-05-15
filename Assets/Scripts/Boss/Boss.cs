using System.Collections;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private Rigidbody rb;
    private IStrategy currentStrategy;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(BossPhaseChange());
    }

    private IEnumerator BossPhaseChange()
    {
        currentStrategy = new BossPhase1(rb);
        yield return new WaitForSeconds(10);
        currentStrategy = new BossPhase2(transform,rb);
        
    }

    
    void Update()
    {
        if (currentStrategy != null)
        {
            currentStrategy.Execute();
        }
    }
}
