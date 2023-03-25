using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencySystem : MonoBehaviour
{
    public Text currency_text;

    public int basicAmountofCurrency;

    public int currency;

    public void Init()
    {
        currency = basicAmountofCurrency;
        UpdateUI();
    }

    public void Gain(int val)
    {
        currency += val;
        UpdateUI();
    }

    void UpdateUI()
    {
        currency_text.text = currency.ToString();
    }

    public bool Use(int val)
    {
        if (EnoughCurrency(val))
        {
            currency -= val;
            UpdateUI();
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool EnoughCurrency(int val)
    {
        if(val >= currency)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
