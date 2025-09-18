using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Video;

namespace Voodoo.Sauce.Internal.CrossPromo.BackupAds.Scripts.Canvas
{
	[RequireComponent(typeof(VideoPlayer))]
	public class SimpleVideoPlayer : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		private VideoPlayer _videoPlayer;

		private RawImage _imageDisplay;

		private RenderTexture _renderTexture;

		private Action _videoClicked;

		public bool SoundEnabled { get; private set; }

		public event Action videoCompleted
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

		public event Action<VideoPlayer> videoPrepared
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

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void PlayVideo(string path)
		{
		}

		public void PlayVideo(VideoClip clip)
		{
		}

		public void PauseVideo(bool pauseStatus)
		{
		}

		public void TryResumeFromPause()
		{
		}

		private void OnLoopPointReached(VideoPlayer source)
		{
		}

		private void OnVideoPrepareCompleted(VideoPlayer source)
		{
		}

		private void TriggerCompleteCallback()
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public void SetVideoClickedCallback(Action onClicked)
		{
		}

		public void ToggleSound()
		{
		}
	}
}
