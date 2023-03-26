using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngotCollector : MonoBehaviour
{
    [SerializeField] GameObject ingots;
    [SerializeField] GameObject rockSocket;
    [SerializeField] GameObject Sword;
    [SerializeField] Transform collectTransform;
    [SerializeField] Transform insideTransform;
    private float ingotDuration = 3.0f;
    bool collectFlag = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !collectFlag)
        {
            collectFlag = true;
            ingots.transform.parent = null;
            ingots.transform.DOMove(collectTransform.position, 1f).OnComplete(ActivateSword);
        }
    }

    private void ActivateSword()
    {
        ingots.transform.DOMove(insideTransform.position, 3f);
        Sword.SetActive(true);
    }
}
