using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollector
{
     private void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("Player") && !collectFlag)
        //{
        //    collectFlag = true;

        //    for (int i = 0; i < rockSocket.transform.childCount; i++)
        //    {
        //        rockList.Add(rockSocket.transform.GetChild(i).gameObject);
        //    }

        //    foreach (GameObject rock in rockList)
        //    {
        //        rock.transform.parent = null;
        //        rock.transform.DOMove(collectTransform.position, 1f).OnComplete(TriggerEvent);
        //    }
        //}
    }

    private void TriggerEvent()
    {
;
    }
}
