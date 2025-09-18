using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace Voodoo.Nakama.Server
{
	public class NakamaTimer : MonoBehaviour
	{
		private readonly List<NakamaDelayedCallback> _callbacks;

		private void Awake()
		{
		}

		[PublicAPI]
		public void DelayedCallback(float seconds, Action callback)
		{
		}

		[PublicAPI]
		public void UpdateCallback(Action callback)
		{
		}

		[PublicAPI]
		public void CancelCallback(Action callback)
		{
		}

		private void Update()
		{
		}
	}
}
