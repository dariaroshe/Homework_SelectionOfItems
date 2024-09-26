using UnityEngine;

namespace DefaultNamespace
{
    public class ProjectileMovement : BaseMovement
    {
        protected override void Move(Vector3 movement)
        {
            transform.position += movement;
        }

        protected override Vector3 GetDirection()
        {
            return transform.forward;
        }
    }
}