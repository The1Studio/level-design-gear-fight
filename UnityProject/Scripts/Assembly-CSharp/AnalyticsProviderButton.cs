using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Voodoo.Sauce.Debugger;

public class AnalyticsProviderButton : Widget
{
	[SerializeField]
	private Button testButton;

	[SerializeField]
	private TextMeshProUGUI titleText;

	[SerializeField]
	private TextMeshProUGUI descText;

	public void SetTitleText(string text)
	{
	}

	public void SetDescText(string text)
	{
	}

	public void SetOnClickListener(UnityAction onClickAction)
	{
	}

	public void SetButtonColor(Color color)
	{
	}
}
