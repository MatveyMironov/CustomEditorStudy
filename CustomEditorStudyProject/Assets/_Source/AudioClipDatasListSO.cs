using System.Collections.Generic;
using UnityEngine;

namespace AudioSystem
{
    [CreateAssetMenu(fileName = "NewAudioClipDatasList", menuName = "Audio Clip Datas List")]
    public class AudioClipDatasListSO : ScriptableObject
    {
        [SerializeField] private AudioContentTypes audioContentType;
        [SerializeField] private List<AudioClipData> dangerousAudioClipDatas = new();
        [SerializeField] private List<AudioClipData> friendlyAudioClipDatas = new();
        [SerializeField] private List<AudioClipData> neutralAudioClipDatas = new();
        [TextArea(5, 10), SerializeField] private string someText;
        [SerializeField] private string id;
    }
}