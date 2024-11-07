using UnityEngine;
using System.Collections.Generic;
using FMODUnity;
using FMOD.Studio;

public class FMODManager : MonoBehaviour
{
    public static FMODManager instance { get; private set; }
    
    private List<EventInstance> eventInstances;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one AudioManagerController found");
        }
        instance = this;
        
        eventInstances = new List<EventInstance>();
    }
}
