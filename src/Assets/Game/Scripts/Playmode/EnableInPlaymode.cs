using UnityEngine;

namespace Game.Scripts.Playmode
{
    public class EnableInPlaymode : MonoBehaviour
    {
        private void Awake()
        {
            { gameObject.SetActive(Application.isEditor); }
        }
    }
}
