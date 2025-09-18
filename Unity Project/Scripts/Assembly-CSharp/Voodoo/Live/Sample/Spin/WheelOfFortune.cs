using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Live.Offers;
using Voodoo.Live.Sample.Offers;
using Voodoo.Live.Sample.Offers.UI;

namespace Voodoo.Live.Sample.Spin
{
	public class WheelOfFortune : FeaturePopup
	{
		[CompilerGenerated]
		private sealed class _003CRewardPlayerUI_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WheelOfFortune _003C_003E4__this;

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
			public _003CRewardPlayerUI_003Ed__36(int _003C_003E1__state)
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
		private sealed class _003CSpinMotion_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WheelOfFortune _003C_003E4__this;

			public float totalRotation;

			private float _003CelapsedTime_003E5__2;

			private float _003CcurrentAngle_003E5__3;

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
			public _003CSpinMotion_003Ed__34(int _003C_003E1__state)
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

		private const string TAG = "WHEEL_OF_FORTUNE";

		public Button closeBtn;

		public Transform wheel;

		public List<Color> sliceColors;

		public WheelPie piePrefab;

		public TextMeshProUGUI rewardDisplay;

		public float spinDuration;

		public AnimationCurve decelerationCurve;

		public OfferPurchaseBtnUI purchaseBtn;

		public OfferPurchaseBtnUI rerollBtn;

		public TextMeshProUGUI purchaseBtnText;

		public TextMeshProUGUI rerollBtnTxt;

		public GameObject bottomGO;

		public GameObject rerollLimitGO;

		public TextMeshProUGUI rerollLimitText;

		public GameObject rewardWindowGO;

		public TextMeshProUGUI rewardTxt;

		public Image rewardIcon;

		public Button rewardCloseBtn;

		public Button spinBtn;

		public GameObject loadingScreen;

		private float _anglePerReward;

		private bool _isSpinning;

		private float _targetAngle;

		private float _currentSpinSpeed;

		private List<Reward> _rewards;

		private Voodoo.Live.Offers.Spin _spin;

		public override void Show()
		{
		}

		public void GenerateWheel(Voodoo.Live.Offers.Spin spin)
		{
		}

		private void SpinWheel()
		{
		}

		private void BuyReroll()
		{
		}

		private void RollUI()
		{
		}

		private float CalculateFinalWheelAngle()
		{
			return 0f;
		}

		private void RerollLimitReached()
		{
		}

		[IteratorStateMachine(typeof(_003CSpinMotion_003Ed__34))]
		private IEnumerator SpinMotion(float totalRotation)
		{
			return null;
		}

		private void Purchase()
		{
		}

		[IteratorStateMachine(typeof(_003CRewardPlayerUI_003Ed__36))]
		private IEnumerator RewardPlayerUI()
		{
			return null;
		}

		public override void Hide()
		{
		}

		public override void OnStatusChanged(string status, IFeature feature)
		{
		}

		private void ShowReward()
		{
		}
	}
}
