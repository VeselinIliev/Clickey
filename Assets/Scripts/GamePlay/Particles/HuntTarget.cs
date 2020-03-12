using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuntTarget : MonoBehaviour
{
    public GameObject target;
    public float speed;
    public int damage;

    private void Start()
    {
        RepositionParticleSystem();
        SetEndPoint();
        PlayParticleSystem();
    }

    void SetEndPoint()
    {
        Vector3 endPoint = target.transform.position;
        endPoint += Vector3.up * .5f;
        transform.LookAt(endPoint); 
        SetParticle(endPoint);
    }

    void RepositionParticleSystem()
    {
        transform.position += Vector3.up * .5f;
    }

    void PlayParticleSystem()
    {
        GetComponent<ParticleSystem>().Play();
    }

    void SetParticle(Vector3 endPoint)
    {
        var duration = Vector3.Distance(transform.position, endPoint) / speed;

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
        target.GetComponent<IEnemy>().TakeDamage(damage);
        Destroy(gameObject);
    }
}
