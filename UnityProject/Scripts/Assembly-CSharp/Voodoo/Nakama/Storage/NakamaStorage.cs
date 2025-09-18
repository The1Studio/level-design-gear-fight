using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using NakamaHttp;
using Voodoo.Nakama.Server;

namespace Voodoo.Nakama.Storage
{
	public class NakamaStorage
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CReadFromCloud_003Ed__25 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public List<string> dataKeys;

			public NakamaStorage _003C_003E4__this;

			public Action<List<StorageObject>> onReadCompleted;

			public Action onError;

			private TaskAwaiter<StorageObjects> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CWriteMultipleDataToCloud_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public List<WriteStorageObject> writeStorageObjects;

			public NakamaStorage _003C_003E4__this;

			public Action<List<StorageObjectAck>> onComplete;

			public Action<List<WriteStorageObject>> onError;

			public Action<List<WriteStorageObject>> onVersionMismatch;

			private TaskAwaiter<StorageObjectAcks> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CWriteToCloud_003Ed__22 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public StorableObject storableObject;

			public NakamaStorage _003C_003E4__this;

			public Action<StorageObjectAck> onComplete;

			public Action<string> onError;

			public Action<string> onVersionMismatch;

			private TaskAwaiter<StorageObjectAcks> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private const string StorageTag = "<color=cyan>[Storage]</color>";

		private const string ReadLocalColor = "green";

		private const string WriteLocalColor = "orange";

		public const string ReadCloudColor = "lime";

		public const string WriteCloudColor = "yellow";

		public const string ErrorColor = "red";

		[PublicAPI]
		public const string CollectionName = "PlayerData";

		public const string LocalDataFolderPrefix = "NakamaLocal_";

		private const string LastSeenDataVersionsPrefix = "NakamaLastSeenCloudVersions_";

		private const float WriteToCloudCooldownInSeconds = 15f;

		private const float ReadFromCloudCooldownInSeconds = 15f;

		private NakamaServer _nakama;

		private long _lastCloudWriteTimestamps;

		private long _lastCloudReadTimestamps;

		private INakamaStorageEncryptionHandler _encryptionHandler;

		private const string LastSavedTimestampPrefix = "SavedDataTimestamp_";

		public static void LogInfo(string message, string color = "white")
		{
		}

		public void UpdateLastSeenVersion(string dataKey, string version)
		{
		}

		public string GetLastSeenVersion(string dataKey)
		{
			return null;
		}

		public void UpdateLastSavedUnixTime(string dataKey, long unixTime)
		{
		}

		public long GetLastSavedUnixTime(string dataKey)
		{
			return 0L;
		}

		public void Init(NakamaServer nakama, INakamaStorageEncryptionHandler encryptionHandler = null)
		{
		}

		[AsyncStateMachine(typeof(_003CWriteToCloud_003Ed__22))]
		public void WriteToCloud(StorableObject storableObject, Action<StorageObjectAck> onComplete, Action<string> onVersionMismatch, Action<string> onError)
		{
		}

		[AsyncStateMachine(typeof(_003CWriteMultipleDataToCloud_003Ed__23))]
		public void WriteMultipleDataToCloud(List<WriteStorageObject> writeStorageObjects, Action<List<StorageObjectAck>> onComplete, Action<List<WriteStorageObject>> onVersionMismatch, Action<List<WriteStorageObject>> onError)
		{
		}

		public void WriteToLocal(string dataKey, string data)
		{
		}

		[AsyncStateMachine(typeof(_003CReadFromCloud_003Ed__25))]
		public void ReadFromCloud(List<string> dataKeys, Action<List<StorageObject>> onReadCompleted, Action onError)
		{
		}

		public string ReadFromLocal(string dataKey)
		{
			return null;
		}

		public bool CanWriteToCloud(bool force)
		{
			return false;
		}

		public bool CanReadFromCloud(bool force)
		{
			return false;
		}

		private string GetFolderPath()
		{
			return null;
		}

		private string GetFilePath(string dataKey)
		{
			return null;
		}

		private bool IsOnline()
		{
			return false;
		}

		public void CleanLocalData()
		{
		}
	}
}
