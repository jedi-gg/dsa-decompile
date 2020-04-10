using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using Zenject;

namespace Glunies
{
	public class GameServiceManager : ILoggable<LogCategory>, IDispatchHandler<DGamedataDomainLoadedAction>, IDispatchHandler, IDispatchHandler<DPlayerChangeProcessedAction>, IDispatchHandler<DExpireRpcCacheAction>
	{
		[FieldOffset(Offset="0x10")]
		private List<AGameServiceClient> _services;

		[FieldOffset(Offset="0x18")]
		private Queue<GameServiceManager.SerialRpcHandle> _pendingRpcHandles;

		[FieldOffset(Offset="0x20")]
		private GameServiceManager.SerialRpcHandle _currentRpcHandle;

		[Attribute(Name="InjectAttribute", RVA="0x1064280", Offset="0x1064280")]
		[FieldOffset(Offset="0x28")]
		private DiContainer _diContainer;

		[Attribute(Name="InjectAttribute", RVA="0x1064290", Offset="0x1064290")]
		[FieldOffset(Offset="0x30")]
		private DispatchSystem _dispatchSystem;

		public LogCategory LogCategory
		{
			[Address(RVA="0x14223C4", Offset="0x14223C4", VA="0x14223C4", Slot="4")]
			get
			{
				return new LogCategory();
			}
		}

		[Address(RVA="0x1424ED8", Offset="0x1424ED8", VA="0x1424ED8")]
		public GameServiceManager()
		{
		}

		[Address(RVA="0x1424D3C", Offset="0x1424D3C", VA="0x1424D3C")]
		private void ClearAllCaches()
		{
		}

		[Address(RVA="0x1424D38", Offset="0x1424D38", VA="0x1424D38", Slot="5")]
		public void HandleDispatchAction(DGamedataDomainLoadedAction action)
		{
		}

		[Address(RVA="0x1424E04", Offset="0x1424E04", VA="0x1424E04", Slot="6")]
		public void HandleDispatchAction(DPlayerChangeProcessedAction action)
		{
		}

		[Address(RVA="0x1424E08", Offset="0x1424E08", VA="0x1424E08", Slot="7")]
		public void HandleDispatchAction(DExpireRpcCacheAction action)
		{
		}

		[Address(RVA="0x1423388", Offset="0x1423388", VA="0x1423388")]
		private void HandleDynamicMessage(DynamicMessage message)
		{
		}

		[Address(RVA="0x14223CC", Offset="0x14223CC", VA="0x14223CC")]
		public void Initialize()
		{
		}

		[Address(RVA="0x14230B8", Offset="0x14230B8", VA="0x14230B8")]
		public void ProcessDynamicMessages(ResponseEnvelope response)
		{
		}

		[Address(RVA="0x1422FC0", Offset="0x1422FC0", VA="0x1422FC0")]
		public void QueueRpc(GameServiceManager.SerialRpc rpc, bool allowParallel)
		{
		}

		[Address(RVA="0x14225A4", Offset="0x14225A4", VA="0x14225A4")]
		public void Shutdown()
		{
		}

		[Address(RVA="0x14226C8", Offset="0x14226C8", VA="0x14226C8")]
		public void TickUpdate()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050FD8", Offset="0x1050FD8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static GameServiceManager.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Action<bool> <>9__5_1;

			[Address(RVA="0x1424F70", Offset="0x1424F70", VA="0x1424F70")]
			static <>c()
			{
			}

			[Address(RVA="0x1424FD4", Offset="0x1424FD4", VA="0x1424FD4")]
			public <>c()
			{
			}

			[Address(RVA="0x1424FDC", Offset="0x1424FDC", VA="0x1424FDC")]
			internal void <TickUpdate>b__5_1(bool _)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050FC8", Offset="0x1050FC8")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset="0x10")]
			public GameServiceManager.SerialRpcHandle next;

			[FieldOffset(Offset="0x18")]
			public GameServiceManager <>4__this;

			[Address(RVA="0x1422838", Offset="0x1422838", VA="0x1422838")]
			public <>c__DisplayClass5_0()
			{
			}

			[Address(RVA="0x1424FE0", Offset="0x1424FE0", VA="0x1424FE0")]
			internal void <TickUpdate>b__0(bool success)
			{
			}
		}

		public delegate void SerialRpc(Action<bool> finished, bool autoFail = false);

		private class SerialRpcHandle
		{
			[FieldOffset(Offset="0x10")]
			public GameServiceManager.SerialRpc RpcFunc;

			[FieldOffset(Offset="0x18")]
			public bool Finished;

			[Address(RVA="0x1423088", Offset="0x1423088", VA="0x1423088")]
			public SerialRpcHandle(GameServiceManager.SerialRpc rpcFunc)
			{
			}
		}
	}
}