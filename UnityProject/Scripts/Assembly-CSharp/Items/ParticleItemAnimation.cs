using System;
using System.Collections.Generic;
using Coffee.UIExtensions;
using DG.Tweening;
using UnityEngine;

namespace Items
{
	[Serializable]
	public class ParticleItemAnimation : ItemAnimation
	{
		private static readonly float FORCED_UPDATE;

		private UIParticle _prefab;

		private UIParticle _uiParticle;

		private UIParticleAttractor _attractor;

		private List<UIParticleAttractor> _attractors;

		private int _attracting;

		private int _totalAttracting;

		private Tween _timerForceUpdate;

		private float _timeScale;

		public override float Progress => 0f;

		public ParticleItemAnimation(UIParticle prefab)
		{
		}

		private void RemoveParticles(UIParticleAttractor attractor)
		{
		}

		private void AddParticles(UIParticleAttractor attractor)
		{
		}

		public void RegisterAttractor(UIParticleAttractor attractor)
		{
		}

		public void UnregisterAttractor(UIParticleAttractor attractor)
		{
		}

		private void OnAttracted()
		{
		}

		private bool TrySpawnParticle()
		{
			return false;
		}

		private void ForceUpdate()
		{
		}

		public override void Animate(int amount, Vector2 position)
		{
		}

		public override void Cancel()
		{
		}

		public override void SetTimeScale(float timeScale)
		{
		}
	}
}
