using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableRock : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Rock") && collision.gameObject.GetComponent<Rigidbody>().isKinematic == false) 
        {
            collision.gameObject.SetActive(false);
        }
    }
}
