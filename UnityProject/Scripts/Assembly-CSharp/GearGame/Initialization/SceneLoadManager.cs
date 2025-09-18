using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Gameplay._Data;
using GearGame.UI;
using ScriptableTemplates;
using UnityEngine;

namespace GearGame.Initialization
{
	public class SceneLoadManager : MonoBehaviour
	{
		[Serializable]
		public class GameScene
		{
			[field: SerializeField]
			public int SceneIndex { get; set; }

			[field: SerializeField]
			public int NumberLevels { get; private set; }
		}

		[CompilerGenerated]
		private sealed class _003CStart_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SceneLoadManager _003C_003E4__this;

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
			public _003CStart_003Ed__38(int _003C_003E1__state)
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

		public readonly List<Task> AdditionalTasks;

		[SerializeField]
		private List<GameObject> _singleLoadSceneObjects;

		[SerializeField]
		private GameObject fullscreenImageCanvas;

		[SerializeField]
		private ChaptersProgressionSettings progressionSettings;

		[SerializeField]
		private ChaptersProgressionSettings _simulationProgressionSettings;

		[SerializeField]
		private StaticDataProvider _staticDataProvider;

		[SerializeField]
		private StaticLevelDataProvider _levelDataProvider;

		[SerializeField]
		private StaticTroopDataProvider _troopDataProvider;

		private static bool _hasStarted;

		public static SceneLoadManager Instance { get; private set; }

		public static bool HasExisted { get; private set; }

		public static BossBattleCanvasController.BossLevel CurrentBossLevel { get; set; }

		public static AsyncOperation CurrentUnLoad { get; set; }

		public static TaskCompletionSource<bool> AsyncReloadingTask { get; internal set; }

		public bool HasInitialized { get; private set; }

		public ChaptersProgressionSettings CurrentChaptersProgression => null;

		private void CreateSingleton()
		{
		}

		private void Awake()
		{
		}

		[IteratorStateMachine(typeof(_003CStart_003Ed__38))]
		private IEnumerator Start()
		{
			return null;
		}

		private void InitializeSave()
		{
		}

		private void Initialize()
		{
		}

		public static void RestartLevel()
		{
		}

		private static void AsyncReload()
		{
		}
	}
}
