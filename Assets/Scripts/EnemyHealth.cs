using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoins = 5;
   
    [Tooltip("Adds amount to maxHitPoins when Enemy dies.")]
    [SerializeField] int difficultyRamp = 1;
    
    int currentHitPoins = 0;

    private Enemy enemy;

    void OnEnable()
    {
        currentHitPoins = maxHitPoins;
    }

    private void Start()
    {
        enemy = GetComponent<Enemy>();
    }
    
    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    void ProcessHit()
    {
        currentHitPoins--;
        if (currentHitPoins <= 0)  {
            gameObject.SetActive(false);
            maxHitPoins += difficultyRamp;
            enemy.RewardGold();
        }
    }
}