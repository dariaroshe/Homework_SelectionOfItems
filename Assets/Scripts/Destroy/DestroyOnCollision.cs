using UnityEngine;

namespace Destroy
{
    public class DestroyOnCollision : MonoBehaviour
    {
        public GameObject IgnoreObject { get; set; }
        
        private void OnTriggerEnter(Collider other)
        {
            if (IgnoreObject == other.gameObject)
            {
                return;
            }
            
            Debug.Log($"{other.gameObject.name}");
            Destroy(gameObject);
        }
    }
}