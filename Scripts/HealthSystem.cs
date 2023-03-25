using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public Text lifeCOunt;

    public int basicHealthCount;

    public int healthCount;

    public void Init()
    {
        healthCount = basicHealthCount;
    }

    public void LoseHealth()
    {
        if (healthCount < 1)
            return;
        healthCount--;
        lifeCOunt.text = healthCount.ToString();

        CheckHealthCount();
    }

    void CheckHealthCount()
    {
        if(healthCount < 1)
        {

        }
        
    }



}
