using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GearGame.Control;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class GearGridController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelaySetOffsets_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GearGridController _003C_003E4__this;

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
			public _003CDelaySetOffsets_003Ed__35(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CDelaySpawnGemGearLevel_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GearGridController _003C_003E4__this;

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
			public _003CDelaySpawnGemGearLevel_003Ed__32(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CStart_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GearGridController _003C_003E4__this;

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
			public _003CStart_003Ed__29(int _003C_003E1__state)
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

		private static GearGridController instance;

		[SerializeField]
		private float rotationOffsetPer;

		[SerializeField]
		private float nearestPegDistanceChecker;

		[SerializeField]
		private float offsetPerPeg;

		[SerializeField]
		private Transform pegSpawningTransform;

		[SerializeField]
		private Transform middleTargetPositionForPegsTransform;

		[SerializeField]
		private GameObject spinnerPrefab;

		[SerializeField]
		private ScriptableGridData defaultGridData;

		[SerializeField]
		private PurchaseableGemGearController gemGearPrefab;

		private readonly List<object> allHighlighters;

		private GearPeg[,] allPegs;

		private bool didInitialize;

		public static GearGridController Instance => null;

		public bool DidInitialize => false;

		public int NumberRows => 0;

		public int NumberColumns => 0;

		public int NumberOfCustomGearsSpawned { get; private set; }

		public event Action<GearController> OnGearChangedOnBoard
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

		private void CreateSingleton()
		{
		}

		private void Awake()
		{
		}

		[IteratorStateMachine(typeof(_003CStart_003Ed__29))]
		private IEnumerator Start()
		{
			return null;
		}

		private void OnEnable()
		{
		}

		private void Initialize()
		{
		}

		[IteratorStateMachine(typeof(_003CDelaySpawnGemGearLevel_003Ed__32))]
		private IEnumerator DelaySpawnGemGearLevel()
		{
			return null;
		}

		public GearPeg[] GetAllPegsInColumn(int column)
		{
			return null;
		}

		public GearPeg[] GetAllPegsInRow(int row)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDelaySetOffsets_003Ed__35))]
		private IEnumerator DelaySetOffsets()
		{
			return null;
		}

		private void SpawnGrid(ScriptableGridData data)
		{
		}

		public void TrySpawnCustomGear(ScriptableGear gear)
		{
		}

		private void TrySpawnCustomGear(string gearGUID)
		{
		}

		private Tuple<GearPeg, Vector2Int> GetPegIndexForDiamondGear()
		{
			return null;
		}

		public void SpawnCustomObjectToBoard(GameObject go, string[] customInformation, Vector2Int position)
		{
		}

		public void GetAllGearsOnBoard(ref List<GearController> gears)
		{
		}

		public void GearChanged(GearController gear)
		{
		}

		public bool TryGetNearestPeg(Vector2 position, out GearPeg peg)
		{
			peg = null;
			return false;
		}

		public void GetAllPegs(ref List<GearPeg> pegs)
		{
		}

		public GearPeg TryGetPegFromIndex(Vector2Int index)
		{
			return null;
		}

		public bool TryGetIndexFromPeg(GearPeg gearPeg, out Vector2Int index)
		{
			index = default(Vector2Int);
			return false;
		}

		public List<GearController> GetGearsAroundPeg(GearPeg peg)
		{
			return null;
		}

		public void RotatePeg(GearPeg peg, ref GearPeg previousPeg, bool clockwise, Vector2Int offset, out List<GearPeg> list)
		{
			list = null;
		}

		public List<Tuple<GearSpinnerController, GearController>> GetAllPegsAroundSpinners(GearController mustFindGear = null)
		{
			return null;
		}

		public bool HasProduction()
		{
			return false;
		}

		public void RotatePeg(GearPeg peg, ref GearPeg previousPeg, bool clockwise)
		{
		}

		public void RotatePeg(GearPeg peg, bool clockwise, ref GearPeg previousPeg, ref GearPeg startingPeg, ref List<GearPeg> ignoreList, bool isPsudoCheck = false)
		{
		}

		public void AddHighlighter(GearController gearController)
		{
		}

		public void RemoveHighlighter(GearController gearController)
		{
		}

		public void ActivateSpeedBurst(float duration, float speedMultiplier)
		{
		}

		public bool TryPlaceGearRandomly(GearController gearDisplay, bool force = true)
		{
			return false;
		}

		private bool TryFindValidPegForPlacement(GearController gearDisplay, int startRow, bool force)
		{
			return false;
		}

		public int GetFreeSpaceCount()
		{
			return 0;
		}

		private bool CheckAdjacentPegsForSpawner(int x, int y, GearController gearDisplay)
		{
			return false;
		}

		private void RandomForcePlacement(GearController gearDisplay)
		{
		}
	}
}
