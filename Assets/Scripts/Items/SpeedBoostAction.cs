using System;
using DefaultNamespace;
using UnityEngine;

namespace Items
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