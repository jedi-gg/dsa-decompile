using Google.Protobuf;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using System.IO;
using WebSocketSharp;

namespace BattleLib
{
	public class RemoteBattleWebsocket : RemoteBattle
	{
		[FieldOffset(Offset="0x0")]
		private readonly static TimeSpan s_pingTimeout;

		[FieldOffset(Offset="0x138")]
		private WebSocket _wsClient;

		[FieldOffset(Offset="0x140")]
		private Queue<string> _incomingControlMessages;

		[FieldOffset(Offset="0x148")]
		private Queue<MessageEventArgs> _incomingMessageQueue;

		[FieldOffset(Offset="0x150")]
		private DateTime _lastPingTime;

		[Address(RVA="0x11114E8", Offset="0x11114E8", VA="0x11114E8")]
		static RemoteBattleWebsocket()
		{
		}

		[Address(RVA="0x1110600", Offset="0x1110600", VA="0x1110600")]
		public RemoteBattleWebsocket(byte localPlayerId, BattleLib_Bootstrap battleData, ByteString battleDataBuffer, string serverAddress, string battleId, string playerToken)
		{
		}

		[Address(RVA="0x1110950", Offset="0x1110950", VA="0x1110950", Slot="14")]
		protected override void Disconnect()
		{
		}

		[Address(RVA="0x1110DC0", Offset="0x1110DC0", VA="0x1110DC0", Slot="17")]
		protected override string GetNextControlMessage()
		{
			return null;
		}

		[Address(RVA="0x1110EF4", Offset="0x1110EF4", VA="0x1110EF4", Slot="18")]
		protected override byte[] GetNextMessage()
		{
			return null;
		}

		[Address(RVA="0x1111104", Offset="0x1111104", VA="0x1111104")]
		private void HandleNetworkClose(object sender, CloseEventArgs e)
		{
		}

		[Address(RVA="0x111103C", Offset="0x111103C", VA="0x111103C")]
		private void HandleNetworkError(object sender, ErrorEventArgs e)
		{
		}

		[Address(RVA="0x1111208", Offset="0x1111208", VA="0x1111208")]
		private void HandleNetworkMessage(object sender, MessageEventArgs e)
		{
		}

		[Address(RVA="0x111147C", Offset="0x111147C", VA="0x111147C")]
		private void HandleNetworkOpen(object sender, EventArgs e)
		{
		}

		[Address(RVA="0x111087C", Offset="0x111087C", VA="0x111087C", Slot="12")]
		protected override void InternalInit(Action<bool> finished)
		{
		}

		[Address(RVA="0x1110AF8", Offset="0x1110AF8", VA="0x1110AF8", Slot="15")]
		protected override void SendControlMessage(BattleLib_Bootstrap.Types.RemoteControl rcType, string data = // 
		// Current member / type: System.Void BattleLib.RemoteBattleWebsocket::SendControlMessage(Serverproto.BattleLib_Bootstrap/Types/RemoteControl,System.String)
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


		[Address(RVA="0x1110D58", Offset="0x1110D58", VA="0x1110D58", Slot="16")]
		protected override void SendMessage(Stream msgStream)
		{
		}

		[Address(RVA="0x11106E8", Offset="0x11106E8", VA="0x11106E8", Slot="9")]
		public override void Update()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050D68", Offset="0x1050D68")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x10")]
			public RemoteBattleWebsocket <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action<bool> finished;

			[Address(RVA="0x1110948", Offset="0x1110948", VA="0x1110948")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x1111568", Offset="0x1111568", VA="0x1111568")]
			internal void <InternalInit>b__0(bool success)
			{
			}
		}
	}
}