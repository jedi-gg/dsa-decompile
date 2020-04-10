using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubActivityPlayer : IMessage<ClubActivityPlayer>, IMessage, IEquatable<ClubActivityPlayer>, IDeepCloneable<ClubActivityPlayer>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubActivityPlayer> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PublicIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string publicId_;

		[FieldOffset(Offset="0x0")]
		public const int CurrentValueFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong currentValue_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094B70", Offset="0x1094B70")]
		public ulong CurrentValue
		{
			[Address(RVA="0x1A49820", Offset="0x1A49820", VA="0x1A49820")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A49828", Offset="0x1A49828", VA="0x1A49828")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094B40", Offset="0x1094B40")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A49528", Offset="0x1A49528", VA="0x1A49528")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094B30", Offset="0x1094B30")]
		public static MessageParser<ClubActivityPlayer> Parser
		{
			[Address(RVA="0x1A493FC", Offset="0x1A493FC", VA="0x1A493FC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094B50", Offset="0x1094B50")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A49618", Offset="0x1A49618", VA="0x1A49618", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094B60", Offset="0x1094B60")]
		public string PublicId
		{
			[Address(RVA="0x1A497A8", Offset="0x1A497A8", VA="0x1A497A8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A497B0", Offset="0x1A497B0", VA="0x1A497B0")]
			set
			{
			}
		}

		[Address(RVA="0x1A49D58", Offset="0x1A49D58", VA="0x1A49D58")]
		static ClubActivityPlayer()
		{
		}

		[Address(RVA="0x1A49674", Offset="0x1A49674", VA="0x1A49674")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ABAC", Offset="0x107ABAC")]
		public ClubActivityPlayer()
		{
		}

		[Address(RVA="0x1A496CC", Offset="0x1A496CC", VA="0x1A496CC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ABBC", Offset="0x107ABBC")]
		public ClubActivityPlayer(ClubActivityPlayer other)
		{
		}

		[Address(RVA="0x1A49B3C", Offset="0x1A49B3C", VA="0x1A49B3C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AC2C", Offset="0x107AC2C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A49748", Offset="0x1A49748", VA="0x1A49748", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ABCC", Offset="0x107ABCC")]
		public ClubActivityPlayer Clone()
		{
			return null;
		}

		[Address(RVA="0x1A49830", Offset="0x1A49830", VA="0x1A49830", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ABDC", Offset="0x107ABDC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A498A4", Offset="0x1A498A4", VA="0x1A498A4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ABEC", Offset="0x107ABEC")]
		public bool Equals(ClubActivityPlayer other)
		{
			return new bool();
		}

		[Address(RVA="0x1A49918", Offset="0x1A49918", VA="0x1A49918", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ABFC", Offset="0x107ABFC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A49C34", Offset="0x1A49C34", VA="0x1A49C34", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AC3C", Offset="0x107AC3C")]
		public void MergeFrom(ClubActivityPlayer other)
		{
		}

		[Address(RVA="0x1A49CAC", Offset="0x1A49CAC", VA="0x1A49CAC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AC4C", Offset="0x107AC4C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A499C4", Offset="0x1A499C4", VA="0x1A499C4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AC0C", Offset="0x107AC0C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A49A2C", Offset="0x1A49A2C", VA="0x1A49A2C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AC1C", Offset="0x107AC1C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F6D8", Offset="0x104F6D8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubActivityPlayer.<>c <>9;

			[Address(RVA="0x1A49E30", Offset="0x1A49E30", VA="0x1A49E30")]
			static <>c()
			{
			}

			[Address(RVA="0x1A49E94", Offset="0x1A49E94", VA="0x1A49E94")]
			public <>c()
			{
			}

			[Address(RVA="0x1A49E9C", Offset="0x1A49E9C", VA="0x1A49E9C")]
			internal ClubActivityPlayer <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}