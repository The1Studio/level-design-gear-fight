using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestItem : MonoBehaviour
{
	public TextMeshProUGUI Description;

	public TextMeshProUGUI Progression;

	public TextMeshProUGUI RewardAmount;

	public Image RewardImage;

	public GameObject BackgroundClaimed;

	public GameObject ClaimedBlocker;

	public GameObject ClaimButton;

	public UIProgressBar FillAmount;

	public Button Clickable;

	public Animator Animator;

	public AudioSource ClaimAudioSource;

	private QuestSO Data;

	public QuestSO Quest => null;

	private void Awake()
	{
	}

	public void Fill(QuestSO _data)
	{
	}

	private void OnEnable()
	{
	}

	public bool CanBeClaimed()
	{
		return false;
	}

	public void UpdateQuest()
	{
	}

	public void OnClaimClick()
	{
	}
}
