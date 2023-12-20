using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator doorAnim;
    // Start is called before the first frame update
    void Start()
    {
        doorAnim = GetComponent<Animator>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerTrigger")) { doorAnim.SetBool("isDoorOpen", true); }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerTrigger"))
        {
            doorAnim.SetBool("isDoorOpen", false);

        }
    }
}
