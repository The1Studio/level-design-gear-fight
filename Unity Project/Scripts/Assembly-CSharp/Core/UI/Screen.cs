using UnityEngine;

namespace Core.UI
{
	public abstract class Screen : MonoBehaviour
	{
		public void Open()
		{
		}

		protected virtual void OnOpen()
		{
		}

		public void Close()
		{
		}

		protected virtual void OnClose()
		{
		}
	}
}
