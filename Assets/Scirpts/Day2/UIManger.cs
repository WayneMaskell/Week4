using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManger : MonoBehaviour
{
    [SerializeField] private TMP_Text updateText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateText() { updateText.SetText("Item collected"); }
    
        
    
}
