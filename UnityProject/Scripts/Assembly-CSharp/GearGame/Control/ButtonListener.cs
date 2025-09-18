using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GearGame.Control
{
	public class ButtonListener : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		public int ChapterIndex { get; set; }

		public event Action<int> OnChapterButtonPressed
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

		public void OnPointerClick(PointerEventData eventData)
		{
		}
	}
}
