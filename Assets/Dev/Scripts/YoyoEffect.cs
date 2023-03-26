using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class YoyoEffect : MonoBehaviour
{
    [SerializeField] float yoyoOffset = 0.2f;
    [SerializeField] private float duration = 2f;

    void Start()
    {
        transform.DOMoveY(transform.position.y + yoyoOffset, duration).SetEase(Ease.InQuad).SetLoops(-1, LoopType.Yoyo);
    }
}
