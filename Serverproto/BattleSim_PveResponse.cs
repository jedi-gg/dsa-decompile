using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleSim_PveResponse : IMessage<BattleSim_PveResponse>, IMessage, IEquatable<BattleSim_PveResponse>, IDeepCloneable<BattleSim_PveResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleSim_PveResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerTeamIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong playerTeamId_;

		[FieldOffset(Offset="0x0")]
		public const int BootstrapFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ByteString bootstrap_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093F40", Offset="0x1093F40")]
		public ByteString Bootstrap
		{
			[Address(RVA="0x1DD3B14", Offset="0x1DD3B14", VA="0x1DD3B14")]
			get
			{
				return null;
			}
			[Address(RVA="0x1DD3B1C", Offset="0x1DD3B1C", VA="0x1DD3B1C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093F10", Offset="0x1093F10")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1DD386C", Offset="0x1DD386C", VA="0x1DD386C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093F00", Offset="0x1093F00")]
		public static MessageParser<BattleSim_PveResponse> Parser
		{
			[Address(RVA="0x1DCF5DC", Offset="0x1DCF5DC", VA="0x1DCF5DC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093F20", Offset="0x1093F20")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1DD3958", Offset="0x1DD3958", VA="0x1DD3958", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093F30", Offset="0x1093F30")]
		public ulong PlayerTeamId
		{
			[Address(RVA="0x1DD3B04", Offset="0x1DD3B04", VA="0x1DD3B04")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1DD3B0C", Offset="0x1DD3B0C", VA="0x1DD3B0C")]
			set
			{
			}
		}

		[Address(RVA="0x1DD4104", Offset="0x1DD4104", VA="0x1DD4104")]
		static BattleSim_PveResponse()
		{
		}

		[Address(RVA="0x1DD39B4", Offset="0x1DD39B4", VA="0x1DD39B4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10795FC", Offset="0x10795FC")]
		public BattleSim_PveResponse()
		{
		}

		[Address(RVA="0x1DD3A28", Offset="0x1DD3A28", VA="0x1DD3A28")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107960C", Offset="0x107960C")]
		public BattleSim_PveResponse(BattleSim_PveResponse other)
		{
		}

		[Address(RVA="0x1DD3EF0", Offset="0x1DD3EF0", VA="0x1DD3EF0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107967C", Offset="0x107967C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1DD3AA4", Offset="0x1DD3AA4", VA="0x1DD3AA4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107961C", Offset="0x107961C")]
		public BattleSim_PveResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1DD3B8C", Offset="0x1DD3B8C", VA="0x1DD3B8C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107962C", Offset="0x107962C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD3C00", Offset="0x1DD3C00", VA="0x1DD3C00", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107963C", Offset="0x107963C")]
		public bool Equals(BattleSim_PveResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD3CCC", Offset="0x1DD3CCC", VA="0x1DD3CCC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107964C", Offset="0x107964C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1DD3FE0", Offset="0x1DD3FE0", VA="0x1DD3FE0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107968C", Offset="0x107968C")]
		public void MergeFrom(BattleSim_PveResponse other)
		{
		}

		[Address(RVA="0x1DD4058", Offset="0x1DD4058", VA="0x1DD4058", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107969C", Offset="0x107969C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1DD3D78", Offset="0x1DD3D78", VA="0x1DD3D78", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107965C", Offset="0x107965C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1DD3DE0", Offset="0x1DD3DE0", VA="0x1DD3DE0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107966C", Offset="0x107966C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F4E8", Offset="0x104F4E8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleSim_PveResponse.<>c <>9;

			[Address(RVA="0x1DD41DC", Offset="0x1DD41DC", VA="0x1DD41DC")]
			static <>c()
			{
			}

			[Address(RVA="0x1DD4240", Offset="0x1DD4240", VA="0x1DD4240")]
			public <>c()
			{
			}

			[Address(RVA="0x1DD4248", Offset="0x1DD4248", VA="0x1DD4248")]
			internal BattleSim_PveResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}