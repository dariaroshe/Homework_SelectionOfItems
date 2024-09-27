using UnityEngine;

namespace Items.Actions
{
    public class HealAction : ItemUseAction
    {
        [SerializeField] private int _healValue;
        
        public override void Use(GameObject user)
        {
            var health = user.GetComponent<Health.Health>();

            if (health != null)
            {
                health.Increase(_healValue);
            }
        }
    }
}