using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestNotificationViewController : MonoBehaviour
{
	[SerializeField]
	private UIProgressBar progressFill;

	[SerializeField]
	private TMP_Text achievementText;

	[SerializeField]
	private TMP_Text achievementProgressText;

	[SerializeField]
	private TMP_Text rewardAmountText;

	[SerializeField]
	private Image currencyImage;

	[SerializeField]
	private Animator anim;

	private bool markToDestroy;

	public bool ToBeDestroyed => false;

	public float Progress
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public void SetAchievementDisplay(Sprite displaySprite)
	{
	}

	public void SetAchievement(string text)
	{
	}

	public void SetAchievementProgress(int min, int max)
	{
	}

	public void SetRewardAmount(string text)
	{
	}

	public void MarkToDestroy()
	{
	}
}
