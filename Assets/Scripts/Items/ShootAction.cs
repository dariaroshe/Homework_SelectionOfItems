using System;
using UnityEngine;

namespace Items
{
    public class ShootAction : ItemUseAction
    {
        [SerializeField] private GameObject _prefab;
        public override void Use(GameObject user)
        {
            Instantiate(_prefab, user.transform.position, user.transform.rotation);
        }
    }
}