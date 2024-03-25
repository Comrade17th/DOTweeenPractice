using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private Material _material;
        
    private void Start()
    {
        _material = GetComponent<Renderer>().material;
        _material.DOColor(_color, _duration).SetLoops(_repeats, _loopType);
    }
}
