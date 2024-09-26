using UnityEngine;

namespace Items
{
    public class ItemsCollector : MonoBehaviour
    {
        public Item CurrentItem { get; private set; }
        [SerializeField] private Transform _itemSlot;
        
        public void Collect(Item item)
        {
            if (CurrentItem != null)
            {
                return;
            }
            
            CurrentItem = item;
            item.transform.SetParent(_itemSlot);
            item.transform.localPosition = Vector3.zero;
            item.transform.localRotation = Quaternion.identity;
            item.GetComponent<Collider>().enabled = false;
        }
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent<Item>(out var item))
            {
                Collect(item);
            }
        }
    }
}