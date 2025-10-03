#region

using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#endregion

namespace RabbitGame.ScriptableObjects
{
    [System.Serializable]
    public class SoundEntry
    {
        public string Key;
        public AudioClip Clip;
    }

    [CreateAssetMenu(menuName = "ScriptableObjects/SoundRegistry", fileName = "SoundRegistry")]
    public class SoundRegistry : ScriptableObject
    {
        public List<SoundEntry> Entries;

        private Dictionary<string, AudioClip> _map;

        public AudioClip Get(string key)
        {
            if (_map == null)
            {
                _map = Entries.ToDictionary(e => e.Key, e => e.Clip);
            }
            if (!_map.ContainsKey(key))
            {
                Debug.LogError($"Sound registry does not contain key: {key}");
                return null;
            }
            return _map[key];
        }
    }
}
