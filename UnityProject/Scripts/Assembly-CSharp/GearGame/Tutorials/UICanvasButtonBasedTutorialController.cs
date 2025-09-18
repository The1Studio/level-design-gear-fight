using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core.UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GearGame.Tutorials
{
	[RequireComponent(typeof(Canvas))]
	public abstract class UICanvasButtonBasedTutorialController : MonoBehaviour
	{
		[Serializable]
		public class HandButton
		{
			public UnityEvent<HandButton> OnStepStarted;

			public UnityEvent<HandButton> OnStepCompleted;

			[SerializeField]
			private string stepUniqueID;

			[field: SerializeField]
			public string ButtonGUID { get; private set; }

			[field: SerializeField]
			public bool MakeCompleteAfterThisStepCompletes { get; private set; }

			[field: SerializeField]
			public Vector2 PositionOffset { get; private set; }

			[field: SerializeField]
			public Vector2 AnchorTargetForHand { get; private set; }

			[field: SerializeField]
			public float DelayHandActivation { get; private set; }

			public string StepUniqueID => null;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRunTutorialStep_003Ed__34 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public UICanvasButtonBasedTutorialController _003C_003E4__this;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[SerializeField]
		protected HandButton[] allHandButtons;

		[SerializeField]
		protected GameObject handRoot;

		[SerializeField]
		private string uniqueID;

		[SerializeField]
		private bool useExpectedStartingTab;

		[SerializeField]
		private Canvas rootTutorialCanvas;

		[SerializeField]
		private MainMenuScreen.Tab expectedStartingTab;

		private Button buttonTarget;

		private HandButton handButton;

		private Transform trackingTransform;

		private bool isDelayActvation;

		private int tutorialOn;

		public MainMenuScreen.Tab ExpectedStartingTab => default(MainMenuScreen.Tab);

		public bool UseExpectedStartingTab => false;

		[field: SerializeField]
		public int Priority { get; private set; }

		public event Action<UICanvasButtonBasedTutorialController> TutorialCompleted
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

		public abstract bool IsTutorialValid();

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnValidate()
		{
		}

		private void UpdateHandPosition()
		{
		}

		public Vector3 GetScreenAnchor()
		{
			return default(Vector3);
		}

		public bool IsTutorialCompleted()
		{
			return false;
		}

		protected virtual Button GetButton(HandButton button)
		{
			return null;
		}

		public void StartTutorial(bool stopCurrentTutorialIfNeeded = false)
		{
		}

		public void ForceStartTutorial()
		{
		}

		public void StopTutorial()
		{
		}

		[AsyncStateMachine(typeof(_003CRunTutorialStep_003Ed__34))]
		protected virtual void RunTutorialStep()
		{
		}

		private void ActivateAllSelectable()
		{
		}
	}
}
