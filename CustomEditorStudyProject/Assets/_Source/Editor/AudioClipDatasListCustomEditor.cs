using UnityEditor;
using UnityEngine;

namespace AudioSystem
{
    [CustomEditor(typeof(AudioClipDatasListSO))]
    public class AudioClipDatasListCustomEditor : Editor
    {
        SerializedProperty audioContentType;
        SerializedProperty dangerousAudioClipDatas;
        SerializedProperty friendlyAudioClipDatas;
        SerializedProperty neutralAudioClipDatas;
        SerializedProperty someText;
        SerializedProperty id;

        private bool _showAudioClipDatas;
        private bool _showSomeText;

        //AudioContentTypes _selectContentType;

        private void OnEnable()
        {
            audioContentType = serializedObject.FindProperty("audioContentType");
            dangerousAudioClipDatas = serializedObject.FindProperty("dangerousAudioClipDatas");
            friendlyAudioClipDatas = serializedObject.FindProperty("friendlyAudioClipDatas");
            neutralAudioClipDatas = serializedObject.FindProperty("neutralAudioClipDatas");
            someText = serializedObject.FindProperty("someText");
            id = serializedObject.FindProperty("id");

            _showAudioClipDatas = false;
            _showSomeText = false;
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            if (GUILayout.Button("Show List"))
            {
                _showAudioClipDatas = true;
            }

            if (_showAudioClipDatas)
            {
                EditorGUILayout.PropertyField(audioContentType);

                AudioContentTypes selectContentType = (AudioContentTypes)audioContentType.enumValueIndex;

                //_selectContentType = (AudioContentTypes)EditorGUILayout.EnumPopup("Audio Content Type", _selectContentType);

                switch (selectContentType)
                {
                    case AudioContentTypes.dangerous:
                        EditorGUILayout.PropertyField(dangerousAudioClipDatas);
                        break;

                    case AudioContentTypes.friendly:
                        EditorGUILayout.PropertyField(friendlyAudioClipDatas);
                        break;

                    case AudioContentTypes.neutral:
                        EditorGUILayout.PropertyField(neutralAudioClipDatas);
                        break;
                }

                EditorGUILayout.Space(10);
            }

            if (GUILayout.Button("Show Text"))
            {
                _showSomeText = true;
            }

            if (_showSomeText)
            {
                EditorGUILayout.PropertyField(someText);
                EditorGUILayout.Space(10);
            }

            if (GUILayout.Button("Hide All"))
            {
                _showAudioClipDatas = false;
                _showSomeText = false;
            }

            EditorGUILayout.Space(10);
            EditorGUILayout.PropertyField(id);

            serializedObject.ApplyModifiedProperties();
        }
    }
}