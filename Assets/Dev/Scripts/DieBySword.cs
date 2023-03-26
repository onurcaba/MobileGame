using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieBySword : MonoBehaviour
{

    [SerializeField] ParticleSystem bloodPS;
    [SerializeField] List<SpriteRenderer> bloodOnTheFloor = new List<SpriteRenderer> ();

    private void Awake()
    {
        //bloodPS = GetComponentInChildren<ParticleSystem>();
        //bloodOnTheFloor = GetComponentInChildren<SpriteRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sword"))
        {
            bloodPS.gameObject.SetActive(true);
            foreach (var p in bloodOnTheFloor)
            { 
                p.gameObject.SetActive(true); 
            }
            //bloodOnTheFloor.transform.parent = null;
        }
    }
}
