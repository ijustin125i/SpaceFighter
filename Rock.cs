using UnityEngine;

public class Rock : MonoBehaviour
{
    // Audio Clips 
    public AudioClip fallingSound; 
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.clip = fallingSound; 
        audioSource.loop = true; 
        audioSource.Play(); 
    }

    
    void OnDestroy()
    {
        // Stop sound when rock is destroyed
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
