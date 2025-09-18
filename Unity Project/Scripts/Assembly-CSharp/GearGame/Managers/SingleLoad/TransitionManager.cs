using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Voodoo.Sauce.Core;

namespace GearGame.Managers.SingleLoad
{
	public class TransitionManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CTransitionSceneRoutine_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TransitionManager _003C_003E4__this;

			public bool showTransitionCanvas;

			public float delay;

			public Action onTransitionCallback;

			public int scene;

			public LoadSceneMode mode;

			public Action onCompleteCallback;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CTransitionSceneRoutine_003Ed__23(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private static TransitionManager instance;

		[SerializeField]
		private Animator animator;

		[SerializeField]
		private Canvas burnAwayCanvasRoot;

		[SerializeField]
		private Image[] burnAwayImages;

		[SerializeField]
		private AudioSource burnAwayAudioSource;

		[SerializeField]
		private GraphicRaycaster raycaster;

		[SerializeField]
		private float fadeRate;

		private readonly int activeHash;

		private bool isTransitioning;

		private bool hasInitialized;

		public static TransitionManager Instance => null;

		public Coroutine TransitionRoutine { get; private set; }

		public bool IsTransitioning => false;

		private void CreateSingleton()
		{
		}

		private void Awake()
		{
		}

		public void FadeAway()
		{
		}

		private void OnVoodooSauceInit(VoodooSauceInitCallbackResult result)
		{
		}

		public void TransitionScene(int sceneId = -1, float delay = 0.5f, LoadSceneMode mode = LoadSceneMode.Single, Action onTransitionCallback = null, bool showTransitionCanvas = true, Action onCompleteCallback = null)
		{
		}

		[IteratorStateMachine(typeof(_003CTransitionSceneRoutine_003Ed__23))]
		private IEnumerator TransitionSceneRoutine(int scene = -1, float delay = 0.5f, LoadSceneMode mode = LoadSceneMode.Single, Action onTransitionCallback = null, bool showTransitionCanvas = true, Action onCompleteCallback = null)
		{
			return null;
		}
	}
}
