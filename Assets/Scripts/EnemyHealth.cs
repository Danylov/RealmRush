using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoins = 5;
    int currentHitPoins = 0;
    
    void OnEnable()
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
        if (currentHitPoins <= 0)  gameObject.SetActive(false);
    }
}
