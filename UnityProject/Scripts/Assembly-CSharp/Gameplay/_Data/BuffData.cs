using System;

namespace Gameplay._Data
{
	[Serializable]
	public abstract class BuffData : GearData
	{
		public abstract string AttachmentType { get; }

		public abstract float Probability { get; }
	}
}
