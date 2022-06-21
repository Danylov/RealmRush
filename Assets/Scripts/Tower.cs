using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] private int cost = 75;
    public bool CreateTower(Tower towerPrefab, Vector3 position)
    {
        Bank bank = GameObject.FindObjectOfType<Bank>();
        if (bank == null) return false;
        if (cost <= bank.CurrentBalance) 
        {
            Instantiate(towerPrefab.gameObject, position, Quaternion.identity);
            bank.Withdraw(cost);
            return true;
        }
        return false;
    }
}