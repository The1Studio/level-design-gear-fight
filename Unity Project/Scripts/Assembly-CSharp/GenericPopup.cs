using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GenericPopup : MonoBehaviour
{
	public class GenericPopupConfig
	{
		public string title;

		public string message;

		public Action cancelCallback;

		public Action confirmCallback;
	}

	[SerializeField]
	private TextMeshProUGUI title;

	[SerializeField]
	private TextMeshProUGUI message;

	[SerializeField]
	private Button cancelButton;

	[SerializeField]
	private Button confirmButton;

	private GenericPopupConfig _config;

	private void Start()
	{
	}

	public void Show(GenericPopupConfig config)
	{
	}

	public void Hide()
	{
	}
}
