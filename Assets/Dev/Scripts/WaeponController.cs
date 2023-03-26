using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaeponController : MonoBehaviour
{
    [SerializeField] Transform waeponSocket;

    [SerializeField] WaeponManager waeponManager;


    int waeponIndex = 0;

    private void Start()
    {
        waeponManager.waepons[0].transform.parent = waeponSocket;
        waeponManager.waepons[0].transform.localPosition = Vector3.zero;
    }

    private void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            SwitchWaepon();
        }
    }

    public void SwitchWaepon()
    {
        waeponManager.waepons[waeponIndex].gameObject.SetActive(false);
        waeponIndex++;

        if (waeponIndex == waeponManager.waepons.Count)
        {
            waeponIndex = 0;
        }
        waeponManager.waepons[waeponIndex].gameObject.SetActive(true);

        waeponManager.waepons[waeponIndex].transform.parent = waeponSocket;
        waeponManager.waepons[waeponIndex].transform.localPosition = Vector3.zero;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WaeponSUpplier"))
        {
            SwitchWaepon();
        }
    }

}
