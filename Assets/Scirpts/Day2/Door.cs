using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator doorAnim;
    AudioManager audioManager;
    // Start is called before the first frame update
    void Start()
    {
        doorAnim = GetComponent<Animator>();
        audioManager = FindObjectOfType<AudioManager>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerTrigger")) { doorAnim.SetBool("isDoorOpen", true);
            audioManager.PlaySFX("DOOR_OPEN");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerTrigger"))
        {
            doorAnim.SetBool("isDoorOpen", false);
            audioManager.PlaySFX("DOOR_CLOSE");

        }
    }
}
