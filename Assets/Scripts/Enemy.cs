using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int goldReward = 40;
    [SerializeField] private int goldPenalty = 10;

    private Bank bank;
    
    void Start()
    {
        bank = FindObjectOfType<Bank>();
    }

    public void RewardGold()
    {
        if (bank == null) return;
        bank.Deposit(goldReward);
    }
    public void StealGold()
    {
        if (bank == null) return;
        bank.Withdraw(goldPenalty);
    }
}
