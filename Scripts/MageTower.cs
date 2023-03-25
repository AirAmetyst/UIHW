using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageTower : MonoBehaviour
{
    public int cost;
    public int health;
    public int damage;
    public int shootInterval;
    public GameObject ammo;
    private void Start()
    {
        StartCoroutine(ShootDelay()); 
    }

    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(shootInterval);
        ShootAmmo();
        StartCoroutine(ShootDelay());
    }

    void ShootAmmo()
    {
        GameObject shootItem = Instantiate(ammo, transform);
    }

    public void Losehealth()
    {
        health--;
        if(health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
