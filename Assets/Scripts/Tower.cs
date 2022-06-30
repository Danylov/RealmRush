using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] private int cost = 75;
    [SerializeField] private float buildDelay = 1f;

    private void Start()
    {
        StartCoroutine(Build());
    }

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

    IEnumerator Build()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
            foreach (Transform grandchild in transform)  grandchild.gameObject.SetActive(false);
        }
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
            yield return new WaitForSeconds(buildDelay);
            foreach (Transform grandchild in transform)  grandchild.gameObject.SetActive(true);
        }
    
    
    }
}