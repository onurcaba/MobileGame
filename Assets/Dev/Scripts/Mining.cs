using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class Mining : MonoBehaviour
{
    [SerializeField] Transform rockSocket;
    GameObject rock;
    [SerializeField] TextMeshProUGUI text;

    int rockAmount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Rock") && Input.GetKey("e"))
        {
            //rock = other.gameObject;
            //other.GetComponent<Rigidbody>().isKinematic = false;
            //Invoke("PositionRockPlayerBack", 0f);
            other.transform.parent = rockSocket;
            other.transform.DOLocalMove(Vector3.zero, 0.5f).OnComplete(IncrementRockAmount);
        }
    }

    void IncrementRockAmount()
    {
        rockAmount = rockSocket.childCount;
        text.text = rockAmount.ToString();
    }
}
