using SBaier.DI;

namespace SBaier.UI
{
    public abstract class ObservablePropertyDisplay<TItem> : PropertyDisplay<ReadonlyObservable<TItem>>, Cleanable
    {
        public override void Initialize()
        {
            base.Initialize();
            _item.OnValueChanged += OnValueChanged;
        }

        public virtual void Clean()
        {
            _item.OnValueChanged -= OnValueChanged;
        }

        private void OnValueChanged(TItem formervalue, TItem newvalue)
        {
            SetText();
        }
    }
}