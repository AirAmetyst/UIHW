using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncomeTower : MonoBehaviour
{
    public int health;
    public int cost;

    public int incomeValue;
    public float interval;
    
    public GameObject obj_coin;

    void Start()
    {
        StartCoroutine(Interval());

    }
    
    
        
    

    IEnumerator Interval()
    {
        yield return new WaitForSeconds(interval);

        IncreaseIncome();

        StartCoroutine(Interval());
    }

    public void IncreaseIncome()
    {
        GameManager.instance.currency.Gain(incomeValue);
        StartCoroutine(CoinIndication());
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    

    IEnumerator CoinIndication()
    {
        obj_coin.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        obj_coin.SetActive(false);
    }

    public void LoseHealth()
    {
        health--;

        if(health <= 0)
        {
            Die();
        }
    }
}
