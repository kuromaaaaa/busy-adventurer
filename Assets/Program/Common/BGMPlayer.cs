using UnityEngine;

public class BGMPlayer : SingletonMonoBehavior<BGMPlayer>
{
    AudioSource audioSource;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
    }
    
    public void Play(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
