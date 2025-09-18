using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GearGame.Utility
{
	public class SimpleActivationTrackingController : MonoBehaviour
	{
		public string GUID { get; set; }

		public event Action<bool> OnActivationStatusChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<string> OnDestroyed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void AttachToObject(Transform target)
		{
		}
	}
}
