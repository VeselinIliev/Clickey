using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuntTarget : MonoBehaviour
{
    public Vector3 target;
    public float speed;

    private void Start()
    {
        transform.position += Vector3.up * .5f;
        target += Vector3.up * .5f;
        transform.LookAt(target);
        SetParticle();
        PlayPS();
    }

    void PlayPS()
    {
        GetComponent<ParticleSystem>().Play();
    }

    void SetParticle()
    {
        var duration = Vector3.Distance(transform.position, target) / speed;

        var main = GetComponent<ParticleSystem>().main;
        main.startSpeed = speed;
        main.duration = duration;
        main.startLifetime = duration;
        main.prewarm = true;
        var emission = GetComponent<ParticleSystem>().emission;

        emission.rateOverTime = 0;
        emission.burstCount = 10;

        var burst = emission.GetBurst(0);
        burst.cycleCount = 1;

        StartCoroutine(DestroyOnReach(duration));
        
    }


    IEnumerator DestroyOnReach(float reachDuration)
    {
        yield return new WaitForSeconds(reachDuration);
        Destroy(gameObject);
    }
}
