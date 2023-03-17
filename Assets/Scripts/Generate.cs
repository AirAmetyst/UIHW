using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _microCube;
    [SerializeField] private GameObject _microSphere;
    [SerializeField] private GameObject _microCylinder;
    [SerializeField] private ModelVariants _reference;
    [SerializeField] private MaterialManager _colorManager;
    
    private GameObject CurrentState;

    public void Factoring()
    {
        CurrentState = _reference.GetCurrentForm();
        string name = CurrentState.name;
        Debug.Log(name);
        if(name == "Cubix")
        {   
            Instantiate(_microCube,new Vector3(Random.Range(-3 , 3), Random.Range(1, 3), Random.Range(-3, 3)), Quaternion.identity);
            Instantiate(_microCube, new Vector3(Random.Range(-3, 3), Random.Range(1, 3), Random.Range(-3, 3)), Quaternion.identity);
            Instantiate(_microCube, new Vector3(Random.Range(-3, 3), Random.Range(1, 3), Random.Range(-3, 3)), Quaternion.identity);
        }
        else if(name == "Sphere")
        {
            Instantiate(_microSphere, new Vector3(Random.Range(-3, 3), Random.Range(1, 3), Random.Range(-3, 3)), Quaternion.identity);
            Instantiate(_microSphere, new Vector3(Random.Range(-3, 3), Random.Range(1, 3), Random.Range(-3, 3)), Quaternion.identity);
            Instantiate(_microSphere, new Vector3(Random.Range(-3, 3), Random.Range(1, 3), Random.Range(-3, 3)), Quaternion.identity);
        }
        else if(name == "Cylinder")
        {
            Instantiate(_microCylinder, new Vector3(Random.Range(-3, 3), Random.Range(1, 3), Random.Range(-3, 3)), Quaternion.identity);
            Instantiate(_microCylinder, new Vector3(Random.Range(-3, 3), Random.Range(1, 3), Random.Range(-3, 3)), Quaternion.identity);
            Instantiate(_microCylinder, new Vector3(Random.Range(-3, 3), Random.Range(1, 3), Random.Range(-3, 3)), Quaternion.identity);
        }
        foreach (MicroCopy mc in FindObjectsOfType<MicroCopy>())
        {
            mc.gameObject.GetComponent<MeshRenderer>().material = _colorManager.Current;
        }
    }

}
