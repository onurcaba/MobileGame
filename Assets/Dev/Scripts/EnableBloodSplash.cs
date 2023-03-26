using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableBloodSplash : MonoBehaviour
{
    void Start()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log(other.name);
        if (other.GetComponent<SpriteRenderer>())
        other.GetComponent<SpriteRenderer>().enabled = true;
    }
}
