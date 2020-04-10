using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubDungeonMap : IMessage<ClubDungeonMap>, IMessage, IEquatable<ClubDungeonMap>, IDeepCloneable<ClubDungeonMap>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubDungeonMap> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int NodesFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ClubDungeonNode> _repeated_nodes_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<ClubDungeonNode> nodes_;

		[FieldOffset(Offset="0x0")]
		public const int MapPrefabFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string mapPrefab_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095610", Offset="0x1095610")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A50B00", Offset="0x1A50B00", VA="0x1A50B00")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095640", Offset="0x1095640")]
		public string MapPrefab
		{
			[Address(RVA="0x1A50DCC", Offset="0x1A50DCC", VA="0x1A50DCC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A50DD4", Offset="0x1A50DD4", VA="0x1A50DD4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095630", Offset="0x1095630")]
		public RepeatedField<ClubDungeonNode> Nodes
		{
			[Address(RVA="0x1A4CA24", Offset="0x1A4CA24", VA="0x1A4CA24")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095600", Offset="0x1095600")]
		public static MessageParser<ClubDungeonMap> Parser
		{
			[Address(RVA="0x1A4CB98", Offset="0x1A4CB98", VA="0x1A4CB98")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095620", Offset="0x1095620")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A50BF0", Offset="0x1A50BF0", VA="0x1A50BF0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A514A4", Offset="0x1A514A4", VA="0x1A514A4")]
		static ClubDungeonMap()
		{
		}

		[Address(RVA="0x1A50C4C", Offset="0x1A50C4C", VA="0x1A50C4C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C67C", Offset="0x107C67C")]
		public ClubDungeonMap()
		{
		}

		[Address(RVA="0x1A50CCC", Offset="0x1A50CCC", VA="0x1A50CCC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C68C", Offset="0x107C68C")]
		public ClubDungeonMap(ClubDungeonMap other)
		{
		}

		[Address(RVA="0x1A511C4", Offset="0x1A511C4", VA="0x1A511C4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C6FC", Offset="0x107C6FC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A50D6C", Offset="0x1A50D6C", VA="0x1A50D6C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C69C", Offset="0x107C69C")]
		public ClubDungeonMap Clone()
		{
			return null;
		}

		[Address(RVA="0x1A50E44", Offset="0x1A50E44", VA="0x1A50E44", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C6AC", Offset="0x107C6AC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A50EB8", Offset="0x1A50EB8", VA="0x1A50EB8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C6BC", Offset="0x107C6BC")]
		public bool Equals(ClubDungeonMap other)
		{
			return new bool();
		}

		[Address(RVA="0x1A50F7C", Offset="0x1A50F7C", VA="0x1A50F7C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C6CC", Offset="0x107C6CC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A512D4", Offset="0x1A512D4", VA="0x1A512D4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C70C", Offset="0x107C70C")]
		public void MergeFrom(ClubDungeonMap other)
		{
		}

		[Address(RVA="0x1A51390", Offset="0x1A51390", VA="0x1A51390", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C71C", Offset="0x107C71C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A51028", Offset="0x1A51028", VA="0x1A51028", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C6DC", Offset="0x107C6DC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A51090", Offset="0x1A51090", VA="0x1A51090", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C6EC", Offset="0x107C6EC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F948", Offset="0x104F948")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubDungeonMap.<>c <>9;

			[Address(RVA="0x1FF1400", Offset="0x1FF1400", VA="0x1FF1400")]
			static <>c()
			{
			}

			[Address(RVA="0x1FF1464", Offset="0x1FF1464", VA="0x1FF1464")]
			public <>c()
			{
			}

			[Address(RVA="0x1FF146C", Offset="0x1FF146C", VA="0x1FF146C")]
			internal ClubDungeonMap <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}