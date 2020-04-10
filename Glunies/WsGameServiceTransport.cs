using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using WebSocketSharp;

namespace Glunies
{
	public class WsGameServiceTransport : IGameServiceTransport, ILoggable<LogCategory>, IDispatchHandler<DServiceNetworkRetryAction>, IDispatchHandler
	{
		[Attribute(Name="InjectAttribute", RVA="0x10642E0", Offset="0x10642E0")]
		[FieldOffset(Offset="0x10")]
		private BootstrapConfig _bootstrapConfig;

		[Attribute(Name="InjectAttribute", RVA="0x10642F0", Offset="0x10642F0")]
		[FieldOffset(Offset="0x18")]
		private GamedataManager _gamedataManager;

		[Attribute(Name="InjectAttribute", RVA="0x1064300", Offset="0x1064300")]
		[FieldOffset(Offset="0x20")]
		private DispatchSystem _dispatch;

		[Attribute(Name="InjectAttribute", RVA="0x1064310", Offset="0x1064310")]
		[FieldOffset(Offset="0x28")]
		private RevSdkController _revSdk;

		[Attribute(Name="InjectAttribute", RVA="0x1064320", Offset="0x1064320")]
		[FieldOffset(Offset="0x30")]
		private GameServiceManager _gameServiceManager;

		[Attribute(Name="InjectAttribute", RVA="0x1064330", Offset="0x1064330")]
		[FieldOffset(Offset="0x38")]
		private GameStateMachine _gameStateMachine;

		[FieldOffset(Offset="0x40")]
		private readonly TimeSpan RECONNECT_WAIT;

		[FieldOffset(Offset="0x48")]
		private readonly TimeSpan RPC_TIMEOUT;

		[FieldOffset(Offset="0x50")]
		private readonly TimeSpan PING_TIMEOUT;

		[FieldOffset(Offset="0x0")]
		private const int NUM_RETRIES_BEFORE_DIALOG = 1;

		[FieldOffset(Offset="0x58")]
		private Serverproto.AuthType _authType;

		[FieldOffset(Offset="0x60")]
		private string _authToken;

		[FieldOffset(Offset="0x68")]
		private ulong _correlationId;

		[FieldOffset(Offset="0x70")]
		private WebSocket _wsClient;

		[FieldOffset(Offset="0x78")]
		private Queue<WsGameServiceTransport.RpcHandle> _rpcsWaitingToSend;

		[FieldOffset(Offset="0x80")]
		private List<WsGameServiceTransport.RpcHandle> _rpcsWaitingForResponse;

		[FieldOffset(Offset="0x88")]
		private Queue<WsGameServiceTransport.RpcHandle> _rpcsCompleted;

		[FieldOffset(Offset="0x90")]
		private Queue<ResponseEnvelope> _outOfBandMessages;

		[FieldOffset(Offset="0x98")]
		private DateTime _lastConnectAttemptTime;

		[FieldOffset(Offset="0xA0")]
		private int _numConnectAttemptsInARow;

		[FieldOffset(Offset="0xA4")]
		private bool _allowReconnect;

		[FieldOffset(Offset="0xA8")]
		private DateTime _lastPingTime;

		[FieldOffset(Offset="0xB0")]
		private bool _timedOut;

		[FieldOffset(Offset="0xB1")]
		private bool _reAuthOnRetry;

		[FieldOffset(Offset="0xB2")]
		private bool _hadError;

		[FieldOffset(Offset="0xB3")]
		private bool _socketClosed;

		private string Glunies.IGameServiceTransport.AuthToken
		{
			[Address(RVA="0x1618968", Offset="0x1618968", VA="0x1618968", Slot="4")]
			get
			{
				return null;
			}
		}

		private Serverproto.AuthType Glunies.IGameServiceTransport.AuthType
		{
			[Address(RVA="0x1618970", Offset="0x1618970", VA="0x1618970", Slot="5")]
			get
			{
				return new Serverproto.AuthType();
			}
		}

		public LogCategory LogCategory
		{
			[Address(RVA="0x1618960", Offset="0x1618960", VA="0x1618960", Slot="11")]
			get
			{
				return new LogCategory();
			}
		}

		[Address(RVA="0x161B448", Offset="0x161B448", VA="0x161B448")]
		public WsGameServiceTransport()
		{
		}

		[Address(RVA="0x161A0A0", Offset="0x161A0A0", VA="0x161A0A0")]
		private void CheckForRpcTimeouts()
		{
		}

		[Address(RVA="0x161964C", Offset="0x161964C", VA="0x161964C")]
		private void CloseConnection(bool forceClose)
		{
		}

		[Address(RVA="0x161A8D0", Offset="0x161A8D0", VA="0x161A8D0")]
		private ulong GetNextCorrelationId()
		{
			return new ulong();
		}

		[Address(RVA="0x161A6D8", Offset="0x161A6D8", VA="0x161A6D8", Slot="10")]
		private void Glunies.IGameServiceTransport.Call(RequestEnvelope requestProtoObject, Action<ResponseEnvelope> success, Action<long, ResponseEnvelope> failure, uint timeoutOverrideS)
		{
		}

		[Address(RVA="0x1618978", Offset="0x1618978", VA="0x1618978", Slot="6")]
		private void Glunies.IGameServiceTransport.Initialize(Serverproto.AuthType authType, string authToken, string timezone, Action<bool> completed)
		{
		}

		[Address(RVA="0x1618EE4", Offset="0x1618EE4", VA="0x1618EE4", Slot="7")]
		private void Glunies.IGameServiceTransport.Reconnect()
		{
		}

		[Address(RVA="0x1618EFC", Offset="0x1618EFC", VA="0x1618EFC", Slot="8")]
		private void Glunies.IGameServiceTransport.Shutdown()
		{
		}

		[Address(RVA="0x161986C", Offset="0x161986C", VA="0x161986C", Slot="9")]
		private void Glunies.IGameServiceTransport.TickUpdate()
		{
		}

		[Address(RVA="0x161A8F8", Offset="0x161A8F8", VA="0x161A8F8", Slot="12")]
		public void HandleDispatchAction(DServiceNetworkRetryAction action)
		{
		}

		[Address(RVA="0x161A9B4", Offset="0x161A9B4", VA="0x161A9B4")]
		private void HandleWebSocketClose(object sender, CloseEventArgs e)
		{
		}

		[Address(RVA="0x161AD2C", Offset="0x161AD2C", VA="0x161AD2C")]
		private void HandleWebSocketError(object sender, ErrorEventArgs e)
		{
		}

		[Address(RVA="0x161ADF4", Offset="0x161ADF4", VA="0x161ADF4")]
		private void HandleWebSocketMessage(object sender, MessageEventArgs e)
		{
		}

		[Address(RVA="0x161A908", Offset="0x161A908", VA="0x161A908")]
		private void HandleWebSocketOpen(object sender, EventArgs e)
		{
		}

		[Address(RVA="0x1618AA4", Offset="0x1618AA4", VA="0x1618AA4")]
		private void OpenConnection(Serverproto.AuthType authType, string authToken)
		{
		}

		[Address(RVA="0x1619F0C", Offset="0x1619F0C", VA="0x1619F0C")]
		private void ProcessCompletedRpcs()
		{
		}

		[Address(RVA="0x1619DB8", Offset="0x1619DB8", VA="0x1619DB8")]
		private void ProcessOutOfBandMessages()
		{
		}

		[Address(RVA="0x161A580", Offset="0x161A580", VA="0x161A580")]
		private void SendRpc(WsGameServiceTransport.RpcHandle rpcHandle)
		{
		}

		[Address(RVA="0x161A8EC", Offset="0x161A8EC", VA="0x161A8EC")]
		public void SetReAuthOnRetry(bool reAuth)
		{
		}

		private class RpcHandle
		{
			[FieldOffset(Offset="0x10")]
			public RequestEnvelope RequestProtoObject;

			[FieldOffset(Offset="0x18")]
			public Action<ResponseEnvelope> SuccessCallback;

			[FieldOffset(Offset="0x20")]
			public Action<long, ResponseEnvelope> FailureCallback;

			[FieldOffset(Offset="0x28")]
			public DateTime TimeSent;

			[FieldOffset(Offset="0x30")]
			public TimeSpan Timeout;

			[FieldOffset(Offset="0x38")]
			public ResponseEnvelope ResponseProtoObject;

			[Address(RVA="0x161A8E4", Offset="0x161A8E4", VA="0x161A8E4")]
			public RpcHandle()
			{
			}
		}
	}
}