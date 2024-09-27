using UnityEngine;

namespace Destroy
{
    public class DestroyOnCollision : MonoBehaviour
    {
        public GameObject IgnoreObject { get; set; }
        [SerializeField] private GameObject _explosionFX;
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.isTrigger)
            {
                return;
            }
            
            if (IgnoreObject == other.gameObject)
            {
                return;
            }

            if (_explosionFX != null)
            {
                Instantiate(_explosionFX, transform.position, transform.rotation);
            }
            
            Destroy(gameObject);
        }
    }
}