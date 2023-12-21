using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip[] audioClips;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void PlaySFX(string audioToPlay) 
    {
        switch (audioToPlay) 
        {
            case "DOOR_OPEN":
                audioSource.PlayOneShot(audioClips[0]);
                break;
            case "DOOR_CLOSE":
                audioSource.PlayOneShot(audioClips[1]);
                break;
            case "PICK_UP_ITEM":
                audioSource.PlayOneShot(audioClips[2]);
                break;
                
        }
        
    }
}
