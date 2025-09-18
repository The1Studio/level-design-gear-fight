using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DebugCopyButton : MonoBehaviour
{
	[SerializeField]
	private List<TextMeshProUGUI> _values;

	[SerializeField]
	private Button _copyButton;

	public event Action buttonClicked
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

	private void Start()
	{
	}

	private void OnButtonClick()
	{
	}
}
