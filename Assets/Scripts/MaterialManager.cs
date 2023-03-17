using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialManager : MonoBehaviour
{

    [SerializeField] private Renderer _cubeRenderer;
    [SerializeField] private Renderer _sphereRenderer;
    [SerializeField] private Renderer _cylinderRenderer;
    public Material Current;
    private void Awake()
    {
        Current = _cubeRenderer.material; 
    }
    public void SetMaterial(Material material) {
        Current = material;
        _cubeRenderer.material = material;
        _sphereRenderer.material = material;
        _cylinderRenderer.material = material;
        foreach(MicroCopy mc in FindObjectsOfType<MicroCopy>())
        {
            mc.gameObject.GetComponent<MeshRenderer>().material = material;
        }
    }

}
