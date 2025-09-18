using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GearGame.Control
{
	[CreateAssetMenu(menuName = "Gameplay/Skill")]
	public class ScriptableSkill : ScriptableObject
	{
		public enum SkillID
		{
			CharacterHealth = 0,
			Coins = 1,
			Damage = 2,
			Dodge = 3,
			FIRSTGEARSET = 4,
			FreeReroll = 5,
			Income = 6,
			Luck = 7,
			PlayerHealth = 8
		}

		[SerializeField]
		private string _displayNameLocKey;

		[SerializeField]
		private string analyticsTrackingID;

		private bool hasBeenCollected;

		private bool valueChanged;

		private float playerPrefSaveTimer;

		public string AnalyticsTrackingID => null;

		[field: SerializeField]
		public SkillID ThisSkillID { get; private set; }

		[field: SerializeField]
		public string ID { get; private set; }

		[field: SerializeField]
		public bool IsTracked { get; private set; }

		[field: SerializeField]
		public Sprite Sprite { get; private set; }

		public double Value { get; private set; }

		public event Action<double> ValueChanged
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

		public void Initialize()
		{
		}

		public void Update()
		{
		}

		public string GetLocalizedDisplayName()
		{
			return null;
		}

		public bool HasCurrencyBeenCollected()
		{
			return false;
		}

		public void Save()
		{
		}

		public void SetValue(double value)
		{
		}

		public void FireEmptyEvent()
		{
		}

		public double IncrementValue(double amount)
		{
			return 0.0;
		}
	}
}
