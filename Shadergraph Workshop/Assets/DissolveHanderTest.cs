using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveHanderTest : MonoBehaviour
{
    [SerializeField] Material dissolveMaterial;
    public void OnSliderChanged(float value)
    {
        dissolveMaterial.SetFloat("DissolveAmount", value);
    }
}
