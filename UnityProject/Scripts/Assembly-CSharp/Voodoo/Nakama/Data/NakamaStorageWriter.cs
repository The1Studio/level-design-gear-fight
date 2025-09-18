using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using NakamaHttp;
using Newtonsoft.Json;
using Voodoo.Nakama.Storage;

namespace Voodoo.Nakama.Data
{
	internal class NakamaStorageWriter
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[StructLayout((LayoutKind)3)]
			private struct _003C_003CWriteMultipleDataToCloud_003Eb__0_003Ed : IAsyncStateMachine
			{
				public int _003C_003E1__state;

				public AsyncTaskMethodBuilder _003C_003Et__builder;

				public _003C_003Ec__DisplayClass10_0 _003C_003E4__this;

				private TaskAwaiter<List<WriteStorageObject>> _003C_003Eu__1;

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

			public Dictionary<string, ServerBaseData> data;

			public NakamaStorageWriter _003C_003E4__this;

			public Dictionary<string, string> keysVersion;

			public bool useBatchSizeLimit;

			public List<WriteStorageObject> writeableStorageList;

			[AsyncStateMachine(typeof(_003C_003CWriteMultipleDataToCloud_003Eb__0_003Ed))]
			internal Task _003CWriteMultipleDataToCloud_003Eb__0()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CServerDataDictionaryToWriteStorageList_003Ed__24 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<List<WriteStorageObject>> _003C_003Et__builder;

			public List<ServerBaseData> data;

			public NakamaStorageWriter _003C_003E4__this;

			public Dictionary<string, string> keysVersion;

			public int limitToBytesAmount;

			private List<WriteStorageObject> _003CstorageList_003E5__2;

			private int _003CtotalSize_003E5__3;

			private List<ServerBaseData>.Enumerator _003C_003E7__wrap3;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

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
		private struct _003CWriteMultipleDataToCloud_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public Dictionary<string, ServerBaseData> data;

			public NakamaStorageWriter _003C_003E4__this;

			public bool useBatchSizeLimit;

			private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

			public Action<List<string>> onSuccessCallback;

			public Action onNextBatchCallback;

			private TaskAwaiter _003C_003Eu__1;

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

		private readonly NakamaStorage m_NakamaStorage;

		private readonly Dictionary<string, ServerBaseData> m_WritingDatas;

		private bool m_SavingToCloud;

		private readonly List<WriteStorageObject> emptyStorage;

		private JsonSerializerSettings jsonSerializerSettings;

		public bool CanWriteToCloud => false;

		public bool CanWriteToCloudForce => false;

		public NakamaStorageWriter(NakamaStorage nakamaStorage)
		{
		}

		[AsyncStateMachine(typeof(_003CWriteMultipleDataToCloud_003Ed__10))]
		public void WriteMultipleDataToCloud(Dictionary<string, ServerBaseData> data, Action<List<string>> onSuccessCallback, bool useBatchSizeLimit = false, Action onNextBatchCallback = null)
		{
		}

		private void ProcessCurrentWriteToCloudBatch(Dictionary<string, ServerBaseData> data, List<WriteStorageObject> writeableStorageList, bool useBatchSizeLimit, Action<List<string>> onSuccessCallback, Action onNextBatchCallback)
		{
		}

		private void OnMultipleCompleteInternal(List<StorageObjectAck> storageObjectsAck, Action<List<string>> onSuccessCallback, Action onNextBatchCallback, bool hasPendingBatches)
		{
		}

		private void OnMultipleMismatchInternal(List<WriteStorageObject> storageObjects, Action<List<string>> onSuccessCallback, Action onNextBatchCallback, bool hasPendingBatches)
		{
		}

		private void OnMultipleDataWrittenToCloud(List<StorageObjectAck> storageObjectsAck, Action<List<string>> onSuccessCallback)
		{
		}

		private void OnDataWrittenToCloud(StorageObjectAck storageObjectAck, Action<string> onSuccessCallback)
		{
		}

		private void OnMultipleVersionMismatch(List<WriteStorageObject> writeStorageObjects, Action<List<string>> onSuccessCallback)
		{
		}

		private void OnVersionMismatch(string key, Action<string> onSuccessCallback)
		{
		}

		private void OnMultipleWriteToCloudError(List<WriteStorageObject> keyStorageObjects)
		{
		}

		private void OnWriteToCloudError(string key)
		{
		}

		public void WriteToLocal(List<ServerBaseData> datas)
		{
		}

		private void EndWriting()
		{
		}

		public static int CalculateWriteStorageObjectSize(WriteStorageObject writeStorageObject)
		{
			return 0;
		}

		private int ServerBaseDataToWriteStorageObject(ServerBaseData baseData, string lastSeenVersion, out WriteStorageObject writeStorageObject)
		{
			writeStorageObject = null;
			return 0;
		}

		[AsyncStateMachine(typeof(_003CServerDataDictionaryToWriteStorageList_003Ed__24))]
		private Task<List<WriteStorageObject>> ServerDataDictionaryToWriteStorageList(List<ServerBaseData> data, Dictionary<string, string> keysVersion, int limitToBytesAmount = -1)
		{
			return null;
		}
	}
}
