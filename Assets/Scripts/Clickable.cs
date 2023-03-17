using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Clickable : MonoBehaviour
{

    [SerializeField] private AnimationCurve _scaleCurve;
    [SerializeField] private float _scaleTime = 0.25f;
    
    //[SerializeField] private HitEffect _cubixEffectPrefab;
    
    [SerializeField] private Generate _generator;
    


    private int _coinsPerClick = 1;

    // ����� ���������� �� Interaction ��� ����� �� ������
    public void HitToCreate()
    {   
            _generator.Factoring();
        
        
        
            
        
        
        
        /*
        HitEffect hitEffect = Instantiate(_hitEffectPrefab, transform.position, Quaternion.identity);
        hitEffect.Init(_coinsPerClick);
        _resources.CollectCoins(1, transform.position);
        */
        StartCoroutine(HitOnCreateAnimation());
    }

    // �������� ��������� ����
    private IEnumerator HitOnCreateAnimation()
    {
        for (float t = 0; t < 1f; t += Time.deltaTime / _scaleTime)
        {
            float scale = _scaleCurve.Evaluate(t);
            transform.localScale = Vector3.one * scale;
            yield return null;
        }
        transform.localScale = Vector3.one;
    }

    // ���� ����� ����������� ���������� �����, ���������� ��� �����
    public void AddCoinsPerClick(int value)
    {
        _coinsPerClick += value;
    }

}
