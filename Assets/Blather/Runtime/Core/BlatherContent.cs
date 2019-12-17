using UnityEngine.Events;

namespace Blather.Runtime.Core
{
    public class BlatherContent<T>
    {
        private T value = default(T);
        public UnityAction ValueChanged;
        
        public T Value
        {
            get => value;
            set => ValueWasUpdated(value);
        }
        
        protected virtual void ValueWasUpdated(T newValue)
        {
            value = newValue;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}