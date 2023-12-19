using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInteraction : MonoBehaviour
{
    private Player player;
    private void Start()
    {
        player = GetComponentInParent<Player>();//retrieve component from player script.
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PickupItem"))
        {
            if (player.HasPickup()) { return; } //Guard Clause

            //Tell Player to Pickup item and give it a reference to the item to pickup
            player.MakeItemAvailableForPickup(other.transform);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PickupItem"))
        {
            //Check if player has left pickup item 
            player.MakeItemNotAvailableForPickup();

        }
    }
}
