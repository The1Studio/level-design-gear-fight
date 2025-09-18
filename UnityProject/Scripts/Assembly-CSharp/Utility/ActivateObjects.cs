using DG.Tweening;
using UnityEngine;

namespace Utility
{
	public class ActivateObjects : MonoBehaviour
	{
		[SerializeField]
		private float _delay;

		[SerializeField]
		private GameObject[] _gameObjects;

		private Tween _tween;

		private void SetActive(bool value)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
