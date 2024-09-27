using System.Collections.Generic;
using UnityEngine;

namespace Items
{
    public class ItemsSpawner : MonoBehaviour
    {
        [SerializeField] private List<Transform> _spawnPoints;
        [SerializeField] private List<GameObject> _items;

        private void Start()
        {
            SpawnItems();
        }

        private void SpawnItems()
        {
            for (int i = 0; i < _spawnPoints.Count; i++)
            {
                var spawnPosition = _spawnPoints[i].position;
                var spawnRotation = _spawnPoints[i].rotation;

                var itemIndex = Random.Range(0, _items.Count);

                Instantiate(_items[itemIndex], spawnPosition, spawnRotation);
            }
        }
    }
}