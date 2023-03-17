using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GetCoins : MonoBehaviour
{

    [SerializeField] private AnimationCurve _scaleCurve;
    [SerializeField] private float _scaleTime = 0.25f;
    [SerializeField] private HitEffect _hitEffectPrefab;
    //[SerializeField] private HitEffect _cubixEffectPrefab;
    private Resources Resources;
    
    


    private int _coinsPerClick = 1;

    // ����� ���������� �� Interaction ��� ����� �� ������
    public void Hit()
    {
        Resources = FindObjectOfType<Resources>();
        
        
        
            HitEffect hitEffect = Instantiate(_hitEffectPrefab, transform.position, Quaternion.identity);
            hitEffect.Init(_coinsPerClick);
            Resources.CollectCoins(1, transform.position);
            DestroyObject(gameObject);


        
        
    }

    // �������� ��������� ����
    

    // ���� ����� ����������� ���������� �����, ���������� ��� �����
    public void AddCoinsPerClick(int value)
    {
        _coinsPerClick += value;
    }

}
