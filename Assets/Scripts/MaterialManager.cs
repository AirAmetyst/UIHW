using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialManager : MonoBehaviour
{

    [SerializeField] private Renderer _cubeRenderer;
    [SerializeField] private Renderer _sphereRenderer;
    [SerializeField] private Renderer _cylinderRenderer;

    public void SetMaterial(Material material) {
        _cubeRenderer.material = material;
        _sphereRenderer.material = material;
        _cylinderRenderer.material = material;
    }

}
