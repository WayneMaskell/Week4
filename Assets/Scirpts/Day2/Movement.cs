using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float horizontalInput;
    float verticalInput;

    [SerializeField] private float Speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        MovePlayer();
        
    }
    private void GetInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        

        
        
    }
    private void MovePlayer() 
    {
        Vector3 movedirection = new Vector3(horizontalInput, 0.0f, verticalInput);
        transform.Translate(movedirection * Speed * Time.deltaTime);
    
    }
}
