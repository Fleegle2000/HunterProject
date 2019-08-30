using UnityEngine;

namespace Game.Scripts.Playmode
{
    public class DisableInPlaymode : MonoBehaviour
    {
        private void Awake()
        { gameObject.SetActive(!Application.isEditor); }
    }
}