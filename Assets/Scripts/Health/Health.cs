using UnityEngine;

namespace Health
{
    public class Health : MonoBehaviour
    {
        public int Value { get; private set; }
        [field: SerializeField] public int MaxValue { get; private set; }

        public bool IsAlive => Value > 0;

        private void Awake()
        {
            Value = MaxValue;
        }

        public void Reduce(int damage)
        {
            Value -= damage;

            if (Value < 0)
            {
                Value = 0;
            }
        }

        public void Increase(int amount)
        {
            Value += amount;

            if (Value > MaxValue)
            {
                Value = MaxValue;
            }
        }
    }
}