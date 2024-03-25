using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private RotateMode _rotateMode;
    
    private void Start()
    {
        transform.DORotate(_position, _duration, _rotateMode).SetLoops(_repeats, _loopType);
    }
}
