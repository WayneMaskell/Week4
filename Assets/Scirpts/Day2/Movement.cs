using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float horizontalInput;
    float verticalInput;
    Vector2 inputVector;

    [SerializeField] private float Speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GetInput();
        MovePlayer();
        GetInputWithKeys(); 
        
    }
    private void GetInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        

        
        
    }
    private void MovePlayer() 
    {
        Vector3 movedirection = new Vector3(inputVector.x, 0.0f, inputVector.y);
        transform.position+= (movedirection * Speed * Time.deltaTime);
        transform.forward = Vector3.Slerp(transform.forward, movedirection, Time.deltaTime * Speed);   
    
    }
    private void GetInputWithKeys() 
    {
        Vector2 input = new Vector2 (0, 0);

        if (Input.GetKey(KeyCode.W))
            {
            input.y = +1;
        
        
        }

        if (Input.GetKey(KeyCode.S))
        {
            input.y = -1;


        }

        if (Input.GetKey(KeyCode.A))
        {
            input.x = -1;


        }

        if (Input.GetKey(KeyCode.D))
        {
            input.x = +1;


        }
        inputVector = input.normalized;




    }
}
