using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;
    private Animator playerAnim;
    public ParticleSystem explosionParticle;
    public ParticleSystem DirtParticle;
    private AudioSource playerAudio;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
      playerRb = GetComponent<Rigidbody>();
      Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();

        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            DirtParticle.Stop(); 
            playerAudio.PlayOneShot(jumpSound, 1f);
        
        
        
        }
        
    }
    private void OnCollisionEnter(Collision collision)

    {
        if (collision.gameObject.CompareTag("Ground")) 
        {
            isOnGround = true;
            DirtParticle.Play();

        }
        else if (collision.gameObject.CompareTag("Obstacle")) 
        {
            gameOver = true;
            Debug.Log("Game Over");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            playerAudio.PlayOneShot(crashSound, 1f);
            DirtParticle.Stop();
        }
    }
    
}
