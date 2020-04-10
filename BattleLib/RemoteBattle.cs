using Glunies;
using Google.Protobuf;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.IO;

namespace BattleLib
{
	public abstract class RemoteBattle : ABattle
	{
		[FieldOffset(Offset="0x0")]
		protected const float INCOMING_MESSAGE_TIMEOUT_S = 10f;

		[FieldOffset(Offset="0x0")]
		protected const int INITIAL_INCOMING_BUFFER_SIZE = 1024;

		[FieldOffset(Offset="0x0")]
		protected const int INITIAL_OUTGOING_BUFFER_SIZE = 1024;

		[FieldOffset(Offset="0x0")]
		protected const int INITIAL_INCOMING_MESSAGE_QUEUE_SIZE = 5;

		[FieldOffset(Offset="0x0")]
		protected const string REMOTE_CONTROL_PREFIX = "rc:";

		[FieldOffset(Offset="0x0")]
		protected const char REMOTE_CONTROL_DATA_SEPARATOR = ':';

		[Attribute(Name="InjectAttribute", RVA="0x1063D6C", Offset="0x1063D6C")]
		[FieldOffset(Offset="0xF8")]
		private GameStateMachine _gameStateMachine;

		[Attribute(Name="InjectAttribute", RVA="0x1063D7C", Offset="0x1063D7C")]
		[FieldOffset(Offset="0x100")]
		private MultiplayerRecovery _mpRecovery;

		[FieldOffset(Offset="0x108")]
		protected RemoteBattle.NetworkCondition _networkCondition;

		[FieldOffset(Offset="0x110")]
		protected string _serverAddress;

		[FieldOffset(Offset="0x118")]
		protected string _battleId;

		[FieldOffset(Offset="0x120")]
		protected string _playerToken;

		[FieldOffset(Offset="0x128")]
		private byte[] _incomingBuffer;

		[FieldOffset(Offset="0x130")]
		private float _battleSpeed;

		public override bool AllowCatchupTimeScale
		{
			[Address(RVA="0x110FDF8", Offset="0x110FDF8", VA="0x110FDF8", Slot="6")]
			get
			{
				return new bool();
			}
		}

		public string BattleId
		{
			[Address(RVA="0x110FE18", Offset="0x110FE18", VA="0x110FE18")]
			get
			{
				return null;
			}
		}

		public override bool DetectBadConnection
		{
			[Address(RVA="0x110FDF0", Offset="0x110FDF0", VA="0x110FDF0", Slot="5")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x110FE20", Offset="0x110FE20", VA="0x110FE20")]
		public RemoteBattle(byte localPlayerId, ByteString battleDataBuffer, string serverAddress, string battleId, string playerToken)
		{
		}

		[Address(RVA="0x110FEC4", Offset="0x110FEC4", VA="0x110FEC4", Slot="7")]
		public override void Begin()
		{
		}

		protected abstract void Disconnect();

		protected abstract string GetNextControlMessage();

		protected abstract byte[] GetNextMessage();

		[Address(RVA="0x1110164", Offset="0x1110164", VA="0x1110164")]
		private void HandleControlMsgString(string controlMsgString)
		{
		}

		[Address(RVA="0x11104D0", Offset="0x11104D0", VA="0x11104D0", Slot="10")]
		public override void PlayerEmote(ulong emoteId)
		{
		}

		protected abstract void SendControlMessage(BattleLib_Bootstrap.Types.RemoteControl rcType, string data = // 
		// Current member / type: System.Void BattleLib.RemoteBattle::SendControlMessage(Serverproto.BattleLib_Bootstrap/Types/RemoteControl,System.String)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void SendControlMessage(Serverproto.BattleLib_Bootstrap/Types/RemoteControl,System.String)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		protected abstract void SendMessage(Stream msgStream);

		[Address(RVA="0x11105BC", Offset="0x11105BC", VA="0x11105BC", Slot="11")]
		public override void SetBattleSpeed(float speed)
		{
		}

		[Address(RVA="0x110FF1C", Offset="0x110FF1C", VA="0x110FF1C", Slot="8")]
		public override void Shutdown()
		{
		}

		[Address(RVA="0x110FF50", Offset="0x110FF50", VA="0x110FF50", Slot="9")]
		public override void Update()
		{
		}

		protected enum NetworkCondition
		{
			[FieldOffset(Offset="0x0")]
			Okay,
			[FieldOffset(Offset="0x0")]
			HadError,
			[FieldOffset(Offset="0x0")]
			AttemptingRecovery
		}
	}
}