using UnityEngine;

namespace Shoot
{
    public class ShootPoint : MonoBehaviour
    {
        [field: SerializeField] public Transform ShootTransform { get; private set; }
    }
}