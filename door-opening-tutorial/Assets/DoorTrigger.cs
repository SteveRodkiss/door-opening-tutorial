using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This will trigger the animations of the door
/// </summary>

public class DoorTrigger : MonoBehaviour
{
    //the animator component
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //if this gets triggered open the door
        if (other.tag == "Player")
        {
            animator.SetBool("Open", true);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.SetBool("Open", false);
        }        
    }


}
