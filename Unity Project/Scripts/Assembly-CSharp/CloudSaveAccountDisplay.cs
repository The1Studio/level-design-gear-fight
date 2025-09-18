using System;
using System.Collections.Generic;
using UnityEngine;

public class CloudSaveAccountDisplay : MonoBehaviour
{
	public class ItemData
	{
		public Sprite Sprite;

		public string Value;
	}

	public List<CloudItemVisual> Visuals;

	private Action _onButtonClicked;

	public void Init(Action onButtonClicked, List<ItemData> datas)
	{
	}

	public void OnButtonClickedEvent()
	{
	}
}
