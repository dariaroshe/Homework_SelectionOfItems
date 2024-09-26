using UnityEngine;

namespace Items
{
    public class HealAction : ItemUseAction
    {
        public override void Use(GameObject user)
        {
            Debug.Log("Лечение");
        }
    }
}