using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

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
    }
}
