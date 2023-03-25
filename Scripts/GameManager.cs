using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Spawner spawner;
    public HealthSystem health;
    public CurrencySystem currency;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        if(TryGetComponent<HealthSystem>(out HealthSystem hs))
        {
            hs.Init();
        }
        if (TryGetComponent<CurrencySystem>(out CurrencySystem cs))
        {
            cs.Init();
        }
    }
}
