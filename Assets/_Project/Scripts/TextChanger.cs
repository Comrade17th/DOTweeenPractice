using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    
    
    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        
        
        sequence.Append(_text.DOText("Заменил на новый стринг", _duration));
        sequence.Append(_text.DOText("Доплнил дополниным дополнением", _duration).SetRelative());
        sequence.Append(_text.DOText("Типа взломал текст, но нет", _duration, true, ScrambleMode.All));
    }
}
