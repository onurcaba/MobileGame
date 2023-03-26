using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneStartEvents : MonoBehaviour
{
    [SerializeField] Transform rockSocket;
    [SerializeField] GameObject ingots;


    private void Start()
    {
        ingots.transform.parent = rockSocket;
        ingots.transform.DOLocalMove(Vector3.zero, 0.5f);

    }


}
