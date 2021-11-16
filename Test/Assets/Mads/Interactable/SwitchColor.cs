using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchColor : MonoBehaviour, IInteractable
{
    [SerializeField] private Material mat1, mat2;
    private bool check;

    private void Start()
    {
        GetComponent<Renderer>().material = mat2;
    }

    public void Trigger()
    {
        Material mat = check ? mat2 : mat1;
        GetComponent<Renderer>().material = mat;
        check = !check;
    }
}