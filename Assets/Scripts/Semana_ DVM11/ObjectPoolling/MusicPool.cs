using System;
using System.Collections.Generic;
using UnityEngine;

public class MusicPool : MonoBehaviour
{
    public SoundPlayer SoundPlayerPrefab;
    public Queue<SoundPlayer> Pool = new();
    public int size = 20;

    public static Action<SoundPlayer> OnFinishAudio;

    private void OnEnable()
    {
        OnFinishAudio += EnqueueAudio;
    }

    void Start()
    {
        for (int i = 0; i < size; i++) 
        {
            SoundPlayer obj = Instantiate(SoundPlayerPrefab, transform);
            obj.gameObject.SetActive(false);
            Pool.Enqueue(obj);
        }
    }

    
    void Update()
    {
        
    }
    public void PlayAudio(string audioName)
    {
        if(Pool.Count == 0)
        {
            Debug.Log("Couldn't find available sounds");
            CreateAudioPlayerObjs(10);
            return;
        }
        AudioClip clip = GameManager.instance.musicDataBase.GetAudio(audioName);
        SoundPlayer soundPlayer = Pool.Dequeue();
        soundPlayer.gameObject.SetActive(true);
        soundPlayer.PlayAudio(clip);
    }
    private void EnqueueAudio(SoundPlayer soundPlayer)
    {
        soundPlayer.gameObject.SetActive(false);
        Pool.Enqueue(soundPlayer);
    }

    private void CreateAudioPlayerObjs(int quantity)
    {
        for(int i = 0;i < quantity; i++)
        {
            SoundPlayer obj = Instantiate(SoundPlayerPrefab, transform);
            obj.gameObject.SetActive(false);
            Pool.Enqueue(obj);
        }
    }
}
