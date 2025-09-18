using System.Collections.Generic;
using GearGame.Control;
using UnityEngine;

namespace GearGame.Managers.SingleLoad
{
	public class CurrencyManager : MonoBehaviour
	{
		private static CurrencyManager instance;

		public static CurrencyManager Instance => null;

		[field: SerializeField]
		public ScriptableSkill[] AllSkills { get; private set; }

		public Dictionary<ScriptableSkill.SkillID, ScriptableSkill> SkillIDDictionary { get; private set; }

		private void CreateSingleton()
		{
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void OnDisable()
		{
		}

		public void InitializeCurrencies()
		{
		}

		public void SaveAllCurrencies(bool saveNakama = false)
		{
		}
	}
}
