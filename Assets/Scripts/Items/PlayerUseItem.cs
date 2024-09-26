using UnityEngine;

namespace Items
{
    public class PlayerUseItem : MonoBehaviour
    {
        [SerializeField] private ItemsCollector _itemsCollector;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (_itemsCollector.CurrentItem != null)
                {
                    _itemsCollector.CurrentItem.Use(gameObject);
                }
                else
                {
                    Debug.Log("У вас нет предмета!");
                }
            }
        }
    }
}