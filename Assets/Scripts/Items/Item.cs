using UnityEngine;

namespace Items
{
    public class Item : MonoBehaviour
    {
        [SerializeField] private ItemUseAction _itemUseAction;

        public void Use(GameObject user)
        {
            Debug.Log($"Предмет использован сущностью {user.name}");
            _itemUseAction.Use(user);
            Debug.Log($"Предмет {gameObject.name} использован");
            Destroy(gameObject);
        }
    }
}