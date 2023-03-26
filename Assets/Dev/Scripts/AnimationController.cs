using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Rigidbody rb;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude > 1 || rb.velocity.magnitude < -1)
        {
            animator.SetBool("isRunning", true);
            animator.transform.localPosition = Vector3.zero;
            animator.transform.localRotation = Quaternion.identity;
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        if (Input.GetKey("e"))
        {
            animator.SetBool("axe", true);
        }
        else
        {
            animator.SetBool("axe", false);
        }
        

    }

    private void AxeAnimation()
    {
        animator.SetBool("axe", true);
    }
}
