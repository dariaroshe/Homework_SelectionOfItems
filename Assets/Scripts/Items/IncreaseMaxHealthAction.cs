using UnityEngine;

namespace Items
{
    public class IncreaseMaxHealthAction : ItemUseAction
    {
        public override void Use(GameObject user)
        {
            Debug.Log("Увеличение здоровья");
        }
    }
}