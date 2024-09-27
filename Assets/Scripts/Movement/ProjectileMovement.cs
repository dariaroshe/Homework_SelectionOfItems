using System;
using UnityEngine;

namespace Movement
{
    public class ProjectileMovement : BaseMovement
    {
        [SerializeField] private Rigidbody _rigidbody;
        
        protected override void Move(Vector3 movement)
        {
            _rigidbody.MovePosition(_rigidbody.position + movement);
        }

        protected override Vector3 GetDirection()
        {
            return transform.forward;
        }
    }
}