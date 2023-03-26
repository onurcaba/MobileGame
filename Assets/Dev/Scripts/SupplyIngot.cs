using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using DG.Tweening;

public class SupplyIngot : MonoBehaviour
{
    [SerializeField] Transform rockSocket;
    [SerializeField] GameObject ingots;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something In");
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player In");

            ingots.transform.parent = rockSocket;
            ingots.transform.DOLocalMove(Vector3.zero, 1f);
        }
    }
}
