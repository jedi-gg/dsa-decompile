using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class GearTierUpRequest : IMessage<GearTierUpRequest>, IMessage, IEquatable<GearTierUpRequest>, IDeepCloneable<GearTierUpRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<GearTierUpRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UnitIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong unitId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098C10", Offset="0x1098C10")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BA3BA8", Offset="0x1BA3BA8", VA="0x1BA3BA8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098C00", Offset="0x1098C00")]
		public static MessageParser<GearTierUpRequest> Parser
		{
			[Address(RVA="0x1BA3B40", Offset="0x1BA3B40", VA="0x1BA3B40")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098C20", Offset="0x1098C20")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BA3C98", Offset="0x1BA3C98", VA="0x1BA3C98", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098C30", Offset="0x1098C30")]
		public ulong UnitId
		{
			[Address(RVA="0x1BA3DC0", Offset="0x1BA3DC0", VA="0x1BA3DC0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1BA3DC8", Offset="0x1BA3DC8", VA="0x1BA3DC8")]
			set
			{
			}
		}

		[Address(RVA="0x1BA413C", Offset="0x1BA413C", VA="0x1BA413C")]
		static GearTierUpRequest()
		{
		}

		[Address(RVA="0x1BA3CF4", Offset="0x1BA3CF4", VA="0x1BA3CF4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108213C", Offset="0x108213C")]
		public GearTierUpRequest()
		{
		}

		[Address(RVA="0x1BA3CFC", Offset="0x1BA3CFC", VA="0x1BA3CFC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108214C", Offset="0x108214C")]
		public GearTierUpRequest(GearTierUpRequest other)
		{
		}

		[Address(RVA="0x1BA3FF0", Offset="0x1BA3FF0", VA="0x1BA3FF0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10821BC", Offset="0x10821BC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BA3D60", Offset="0x1BA3D60", VA="0x1BA3D60", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108215C", Offset="0x108215C")]
		public GearTierUpRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1BA3DD0", Offset="0x1BA3DD0", VA="0x1BA3DD0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108216C", Offset="0x108216C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA3E44", Offset="0x1BA3E44", VA="0x1BA3E44", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108217C", Offset="0x108217C")]
		public bool Equals(GearTierUpRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA3E80", Offset="0x1BA3E80", VA="0x1BA3E80", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108218C", Offset="0x108218C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BA4080", Offset="0x1BA4080", VA="0x1BA4080", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10821CC", Offset="0x10821CC")]
		public void MergeFrom(GearTierUpRequest other)
		{
		}

		[Address(RVA="0x1BA40C0", Offset="0x1BA40C0", VA="0x1BA40C0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10821DC", Offset="0x10821DC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BA3EE8", Offset="0x1BA3EE8", VA="0x1BA3EE8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108219C", Offset="0x108219C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BA3F50", Offset="0x1BA3F50", VA="0x1BA3F50", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10821AC", Offset="0x10821AC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050198", Offset="0x1050198")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static GearTierUpRequest.<>c <>9;

			[Address(RVA="0x1BA4214", Offset="0x1BA4214", VA="0x1BA4214")]
			static <>c()
			{
			}

			[Address(RVA="0x1BA4278", Offset="0x1BA4278", VA="0x1BA4278")]
			public <>c()
			{
			}

			[Address(RVA="0x1BA4280", Offset="0x1BA4280", VA="0x1BA4280")]
			internal GearTierUpRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}