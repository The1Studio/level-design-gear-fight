using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Privacy.UI
{
	[RequireComponent(typeof(GraphicRaycaster))]
	[RequireComponent(typeof(Canvas))]
	public class LoadingScreen : MonoBehaviour
	{
		[SerializeField]
		private Image _spinner;

		[SerializeField]
		private float _speed;

		private void Update()
		{
		}
	}
}
