using Movement;
using UnityEngine;

namespace Items.Actions
{
    public class SpeedBoostAction : ItemUseAction
    {
        [SerializeField] private float _speedBoost;
        
        public override void Use(GameObject user)
        {
            var movement = user.GetComponent<BaseCharacterMovement>();

            if (movement != null)
            {
                movement.Speed += _speedBoost;
            }
        }
    }
}