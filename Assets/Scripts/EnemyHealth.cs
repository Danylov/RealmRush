using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoins = 5;
    int currentHitPoins = 0;
    
    void Start()
    {
        currentHitPoins = maxHitPoins;
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    void ProcessHit()
    {
        currentHitPoins--;
        if (currentHitPoins <= 0)  Destroy(gameObject);
    }
}
