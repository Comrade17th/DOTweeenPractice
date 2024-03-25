using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CapsuleScaling : MonoBehaviour
{
    [SerializeField] private Vector3 _scaleTo;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
        
    private void Start()
    {
        transform.DOScale(_scaleTo, _duration).SetLoops(_repeats, _loopType);
    }
}
