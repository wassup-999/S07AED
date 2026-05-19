using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[CreateAssetMenu(fileName = "MusicDataBase", menuName = "Scriptable Objects/MusicDataBase")]
public class MusicDataBase : SerializedScriptableObject
{
    public Dictionary<string, AudioClip> ClipDataBase = new();

    public AudioClip GetAudio(string audioName)
    {
        if(ClipDataBase.TryGetValue(audioName , out AudioClip clip))
        {
            return clip; 
        }
        else
        {
            throw new System.Exception("The audio trying to get doesn't exist");
        }        
    }
}
