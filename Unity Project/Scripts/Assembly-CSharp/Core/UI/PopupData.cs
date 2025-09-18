using System;

namespace Core.UI
{
	[Serializable]
	internal abstract class PopupData
	{
		public string Id;

		public Popup Prefab;

		public BackdropUsage BackdropUsage;

		public PopupUsage PopupUsage;

		public int Priority;

		public abstract void Close(Popup popup);

		public abstract void Open(Popup popup);

		public abstract void Destroy(Popup popup);
	}
	internal class PopupData<T> : PopupData where T : Popup
	{
		public Action<T> onClose;

		public Action<T> onOpen;

		public Action<T> onDestroy;

		public override void Close(Popup popup)
		{
		}

		public override void Open(Popup popup)
		{
		}

		public override void Destroy(Popup popup)
		{
		}
	}
}
