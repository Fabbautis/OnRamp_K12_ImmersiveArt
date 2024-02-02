using System;
using UnityEngine;

public class ARObject : MonoBehaviour
{

    private Animator _animator;

    private static readonly int ARObjectActivate = Animator.StringToHash("ARObjectActivate");

    public void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void ActivateARObject()
    {
        _animator.SetTrigger(ARObjectActivate);
    }
    
}
