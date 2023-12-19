using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private bool hasPickup = false;
    private bool isAvailiableForPickup;
    private Transform currentItemAvailableForPickup;
    [SerializeField]private Transform pickupTransform;
    public UnityEvent onItemPickup;
    // Start is called before the first frame update
    void Start()
    {
        onItemPickup.AddListener(PickUpItem);

    }

    // Update is called once per frame
    void Update()
    {
        if (isAvailiableForPickup) 
        { 
            if (Input.GetKeyDown(KeyCode.H)) { PickUpItem(); }
             
         
            
        }
        if ( Input.GetKeyDown(KeyCode.J))
        {
            DropItem();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onItemPickup.RemoveListener(PickUpItem);
        }


    }
    public void PickUpItem() 
    {
       currentItemAvailableForPickup.position = pickupTransform.position;
        currentItemAvailableForPickup.SetParent(pickupTransform);
        hasPickup = true;
        onItemPickup.Invoke();
    }
    private void DropItem() 
    {
        if (currentItemAvailableForPickup != null) 
        { currentItemAvailableForPickup.SetParent(null);
            hasPickup = false;
        }

    
    
    
    }
    public void MakeItemAvailableForPickup(Transform itemToPickup) 
    {
        currentItemAvailableForPickup = itemToPickup;
        isAvailiableForPickup = true;   
    
    
    
    }
    
    
        
    
    public bool HasPickup() 
    {  return hasPickup; }

    public void MakeItemNotAvailableForPickup() 
    {
        currentItemAvailableForPickup=null;
        isAvailiableForPickup = false;

    
    
    
    }

}
