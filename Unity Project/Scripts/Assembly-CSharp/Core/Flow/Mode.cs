using System;
using UnityEngine;

namespace Core.Flow
{
	public abstract class Mode : MonoBehaviour
	{
		private bool _initialized;

		private Action<System.Type> _changeMode;

		protected bool IsActive;

		public void OnEnter()
		{
		}

		public void OnExit()
		{
		}

		protected virtual void Initialize()
		{
		}

		public void Setup(Action<System.Type> changeModeByType)
		{
		}

		public void ChangeMode<T>() where T : Mode
		{
		}

		protected abstract void OnEnterInternal();

		protected abstract void OnExitInternal();
	}
}
