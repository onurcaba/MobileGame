using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectRocks : MonoBehaviour
{
    [SerializeField]List<GameObject>  rockList= new List<GameObject>();
    [SerializeField] GameObject rockSocket;
    [SerializeField] GameObject Ingots;
    [SerializeField] Transform collectTransform;
    [SerializeField] Transform insideTransform;
    [SerializeField] Transform ingotTransform;
    private float ingotDuration = 3.0f;
    bool collectFlag = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !collectFlag)
        {
            collectFlag= true;

            for (int i = 0; i < rockSocket.transform.childCount; i++)
            {
                rockList.Add(rockSocket.transform.GetChild(i).gameObject);
            }

            foreach (GameObject rock in rockList)
            {
                rock.transform.parent= null;
                rock.transform.DOMove(collectTransform.position, 1f).OnComplete(ToIngot);
            }
        }
    }

    private void ToIngot()
    { 
        foreach (GameObject rock in rockList)
        {
            rock.transform.DOMove(insideTransform.position, ingotDuration);
        }
        Ingots.transform.DOMove(ingotTransform.position, ingotDuration);
    }
}
