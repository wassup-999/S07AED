using UnityEngine;

[RequireComponent (typeof(AudioSource))]
public class SoundPlayer : MonoBehaviour
{
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource> ();
    }
    
    void Update()
    {
        
    }
    public void PlayAudio(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();//-> reproduce sonido

        Invoke(nameof(ReturnToPool), audioSource.clip.length);
    }
    public void ReturnToPool()
    {
        audioSource.clip = null;

    }
}
