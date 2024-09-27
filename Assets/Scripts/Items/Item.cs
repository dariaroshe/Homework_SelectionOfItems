using System;
using UnityEngine;

namespace Items
{
    public class Item : MonoBehaviour
    {
        [SerializeField] private ItemUseAction _itemUseAction;
        [SerializeField] private GameObject _useFx;

        public void Use(GameObject user)
        {
            if (_useFx != null)
            {
                Instantiate(_useFx, transform.position, Quaternion.identity, user.transform);
            }

            Debug.Log($"Предмет {gameObject.name} использован сущностью {user.name}");
            _itemUseAction.Use(user);
            
            Destroy(gameObject);
        }
    }
}