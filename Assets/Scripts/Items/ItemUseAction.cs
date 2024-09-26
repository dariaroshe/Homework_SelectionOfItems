using UnityEngine;

namespace Items
{
    public abstract class ItemUseAction : MonoBehaviour
    {
        public abstract void Use(GameObject user);
    }
}