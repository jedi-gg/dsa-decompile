using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PlayerProfileRequest : IMessage<PlayerProfileRequest>, IMessage, IEquatable<PlayerProfileRequest>, IDeepCloneable<PlayerProfileRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PlayerProfileRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string id_;

		[FieldOffset(Offset="0x0")]
		public const int IncludePlayerFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private bool includePlayer_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A610", Offset="0x109A610")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1AFC3A0", Offset="0x1AFC3A0", VA="0x1AFC3A0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A630", Offset="0x109A630")]
		public string Id
		{
			[Address(RVA="0x1AFC61C", Offset="0x1AFC61C", VA="0x1AFC61C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1AFC624", Offset="0x1AFC624", VA="0x1AFC624")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A640", Offset="0x109A640")]
		public bool IncludePlayer
		{
			[Address(RVA="0x1AFC694", Offset="0x1AFC694", VA="0x1AFC694")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1AFC69C", Offset="0x1AFC69C", VA="0x1AFC69C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A600", Offset="0x109A600")]
		public static MessageParser<PlayerProfileRequest> Parser
		{
			[Address(RVA="0x1AFC338", Offset="0x1AFC338", VA="0x1AFC338")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A620", Offset="0x109A620")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1AFC48C", Offset="0x1AFC48C", VA="0x1AFC48C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1AFCBB8", Offset="0x1AFCBB8", VA="0x1AFCBB8")]
		static PlayerProfileRequest()
		{
		}

		[Address(RVA="0x1AFC4E8", Offset="0x1AFC4E8", VA="0x1AFC4E8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10847FC", Offset="0x10847FC")]
		public PlayerProfileRequest()
		{
		}

		[Address(RVA="0x1AFC540", Offset="0x1AFC540", VA="0x1AFC540")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108480C", Offset="0x108480C")]
		public PlayerProfileRequest(PlayerProfileRequest other)
		{
		}

		[Address(RVA="0x1AFC9CC", Offset="0x1AFC9CC", VA="0x1AFC9CC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108487C", Offset="0x108487C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1AFC5BC", Offset="0x1AFC5BC", VA="0x1AFC5BC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108481C", Offset="0x108481C")]
		public PlayerProfileRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1AFC6A8", Offset="0x1AFC6A8", VA="0x1AFC6A8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108482C", Offset="0x108482C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1AFC71C", Offset="0x1AFC71C", VA="0x1AFC71C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108483C", Offset="0x108483C")]
		public bool Equals(PlayerProfileRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1AFC7A0", Offset="0x1AFC7A0", VA="0x1AFC7A0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108484C", Offset="0x108484C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1AFCA90", Offset="0x1AFCA90", VA="0x1AFCA90", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108488C", Offset="0x108488C")]
		public void MergeFrom(PlayerProfileRequest other)
		{
		}

		[Address(RVA="0x1AFCB08", Offset="0x1AFCB08", VA="0x1AFCB08", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108489C", Offset="0x108489C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1AFC850", Offset="0x1AFC850", VA="0x1AFC850", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108485C", Offset="0x108485C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1AFC8B8", Offset="0x1AFC8B8", VA="0x1AFC8B8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108486C", Offset="0x108486C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050518", Offset="0x1050518")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PlayerProfileRequest.<>c <>9;

			[Address(RVA="0x1AFCC90", Offset="0x1AFCC90", VA="0x1AFCC90")]
			static <>c()
			{
			}

			[Address(RVA="0x1AFCCF4", Offset="0x1AFCCF4", VA="0x1AFCCF4")]
			public <>c()
			{
			}

			[Address(RVA="0x1AFCCFC", Offset="0x1AFCCFC", VA="0x1AFCCFC")]
			internal PlayerProfileRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}