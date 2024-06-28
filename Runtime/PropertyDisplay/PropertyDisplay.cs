using SBaier.DI;
using TMPro;
using UnityEngine;

namespace SBaier.UI
{
	public abstract class PropertyDisplay : MonoBehaviour, Initializable
	{
		[SerializeField]
		private TextMeshProUGUI _text;

		private void Reset()
		{
			_text = GetComponent<TextMeshProUGUI>();
		}

		public virtual void Initialize()
		{
			SetText();
		}

		protected void SetText()
		{
			_text.text = GetText();
		}

		protected abstract string GetText();
	}
	
    public abstract class PropertyDisplay<TItem> : PropertyDisplay, Injectable
    {
		protected TItem _item;

		public virtual void Inject(Resolver resolver)
		{
			_item = resolver.Resolve<TItem>();
		}
	}
	
    public abstract class PropertyDisplay<TItem, TSecondItem> : PropertyDisplay, Injectable
    {
		protected TItem _item;
		protected TSecondItem _secondItem;

		public virtual void Inject(Resolver resolver)
		{
			_item = resolver.Resolve<TItem>();
			_secondItem = resolver.Resolve<TSecondItem>();
		}
	}
}
