using System;
using UnityEngine;

namespace AudioSystem
{
    [Serializable]
    public class AudioClipData
    {
        [SerializeField] private AudioClip audioClip;
        [Range(0f, 1.0f), SerializeField] private float volume;
    }
}