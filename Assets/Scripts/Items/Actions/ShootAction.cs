using Destroy;
using Shoot;
using UnityEngine;

namespace Items.Actions
{
    public class ShootAction : ItemUseAction
    {
        [SerializeField] private GameObject _prefab;
        
        public override void Use(GameObject user)
        {
            if (user.TryGetComponent<ShootPoint>(out var shootPoint))
            {
                SpawnProjectile(shootPoint.ShootTransform, user);
            }
            else
            {
                SpawnProjectile(user.transform, user);
            }
        }

        private void SpawnProjectile(Transform spawnPoint, GameObject ignoreObject)
        {
            var projectile = Instantiate(_prefab, spawnPoint.position, spawnPoint.rotation);
            var projectileDestroyComponent = projectile.GetComponent<DestroyOnCollision>();
            projectileDestroyComponent.IgnoreObject = ignoreObject;
        }
    }
}