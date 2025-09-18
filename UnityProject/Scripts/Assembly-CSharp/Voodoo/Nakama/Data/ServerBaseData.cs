using System;

namespace Voodoo.Nakama.Data
{
	[Serializable]
	public abstract class ServerBaseData : IComparable<ServerBaseData>
	{
		[NonSerialized]
		public Action<ServerBaseData> OnSave;

		private bool _hasBeenInitializedFromDefault;

		public void Save()
		{
		}

		public virtual void OnLoaded()
		{
		}

		public void Init()
		{
		}

		public virtual void InitFromDefaults()
		{
		}

		public virtual int CompareTo(ServerBaseData other)
		{
			return 0;
		}

		public virtual int GetArbitratingWeight()
		{
			return 0;
		}
	}
}
