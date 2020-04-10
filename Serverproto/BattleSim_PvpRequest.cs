using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleSim_PvpRequest : IMessage<BattleSim_PvpRequest>, IMessage, IEquatable<BattleSim_PvpRequest>, IDeepCloneable<BattleSim_PvpRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleSim_PvpRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerOneFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private BattleSim_SimplePlayer playerOne_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerTwoFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private BattleSim_SimplePlayer playerTwo_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093E10", Offset="0x1093E10")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1DD42A0", Offset="0x1DD42A0", VA="0x1DD42A0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093E00", Offset="0x1093E00")]
		public static MessageParser<BattleSim_PvpRequest> Parser
		{
			[Address(RVA="0x1DCF4A4", Offset="0x1DCF4A4", VA="0x1DCF4A4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093E20", Offset="0x1093E20")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1DD438C", Offset="0x1DD438C", VA="0x1DD438C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093E30", Offset="0x1093E30")]
		public BattleSim_SimplePlayer PlayerOne
		{
			[Address(RVA="0x1DD4478", Offset="0x1DD4478", VA="0x1DD4478")]
			get
			{
				return null;
			}
			[Address(RVA="0x1DD44E0", Offset="0x1DD44E0", VA="0x1DD44E0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093E40", Offset="0x1093E40")]
		public BattleSim_SimplePlayer PlayerTwo
		{
			[Address(RVA="0x1DD44E8", Offset="0x1DD44E8", VA="0x1DD44E8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1DD44F0", Offset="0x1DD44F0", VA="0x1DD44F0")]
			set
			{
			}
		}

		[Address(RVA="0x1DD4C88", Offset="0x1DD4C88", VA="0x1DD4C88")]
		static BattleSim_PvpRequest()
		{
		}

		[Address(RVA="0x1DD43E8", Offset="0x1DD43E8", VA="0x1DD43E8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10793EC", Offset="0x10793EC")]
		public BattleSim_PvpRequest()
		{
		}

		[Address(RVA="0x1DD43F0", Offset="0x1DD43F0", VA="0x1DD43F0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10793FC", Offset="0x10793FC")]
		public BattleSim_PvpRequest(BattleSim_PvpRequest other)
		{
		}

		[Address(RVA="0x1DD4814", Offset="0x1DD4814", VA="0x1DD4814", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107946C", Offset="0x107946C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1DD44F8", Offset="0x1DD44F8", VA="0x1DD44F8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107940C", Offset="0x107940C")]
		public BattleSim_PvpRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1DD4558", Offset="0x1DD4558", VA="0x1DD4558", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107941C", Offset="0x107941C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD45CC", Offset="0x1DD45CC", VA="0x1DD45CC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107942C", Offset="0x107942C")]
		public bool Equals(BattleSim_PvpRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD4644", Offset="0x1DD4644", VA="0x1DD4644", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107943C", Offset="0x107943C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1DD48E8", Offset="0x1DD48E8", VA="0x1DD48E8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107947C", Offset="0x107947C")]
		public void MergeFrom(BattleSim_PvpRequest other)
		{
		}

		[Address(RVA="0x1DD4B7C", Offset="0x1DD4B7C", VA="0x1DD4B7C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107948C", Offset="0x107948C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1DD46B4", Offset="0x1DD46B4", VA="0x1DD46B4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107944C", Offset="0x107944C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1DD471C", Offset="0x1DD471C", VA="0x1DD471C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107945C", Offset="0x107945C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F4B8", Offset="0x104F4B8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleSim_PvpRequest.<>c <>9;

			[Address(RVA="0x1DD4D60", Offset="0x1DD4D60", VA="0x1DD4D60")]
			static <>c()
			{
			}

			[Address(RVA="0x1DD4DC4", Offset="0x1DD4DC4", VA="0x1DD4DC4")]
			public <>c()
			{
			}

			[Address(RVA="0x1DD4DCC", Offset="0x1DD4DCC", VA="0x1DD4DCC")]
			internal BattleSim_PvpRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}