using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class DissolveHandler : MonoBehaviour
{
    [SerializeField] Material dissolveMaterial;

    public void OnSliderChanged(float value)
    {
        dissolveMaterial.SetFloat("MixAmount", value);
    }
}
