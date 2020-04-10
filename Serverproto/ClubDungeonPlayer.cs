using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubDungeonPlayer : IMessage<ClubDungeonPlayer>, IMessage, IEquatable<ClubDungeonPlayer>, IDeepCloneable<ClubDungeonPlayer>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubDungeonPlayer> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PublicIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string publicId_;

		[FieldOffset(Offset="0x0")]
		public const int CurrentMapFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong currentMap_;

		[FieldOffset(Offset="0x0")]
		public const int CurrentNodeFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong currentNode_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10958B0", Offset="0x10958B0")]
		public ulong CurrentMap
		{
			[Address(RVA="0x1FF2378", Offset="0x1FF2378", VA="0x1FF2378")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FF2380", Offset="0x1FF2380", VA="0x1FF2380")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10958C0", Offset="0x10958C0")]
		public ulong CurrentNode
		{
			[Address(RVA="0x1FF2388", Offset="0x1FF2388", VA="0x1FF2388")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FF2390", Offset="0x1FF2390", VA="0x1FF2390")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095880", Offset="0x1095880")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FF2068", Offset="0x1FF2068", VA="0x1FF2068")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095870", Offset="0x1095870")]
		public static MessageParser<ClubDungeonPlayer> Parser
		{
			[Address(RVA="0x1FF2000", Offset="0x1FF2000", VA="0x1FF2000")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095890", Offset="0x1095890")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FF2154", Offset="0x1FF2154", VA="0x1FF2154", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10958A0", Offset="0x10958A0")]
		public string PublicId
		{
			[Address(RVA="0x1FF2300", Offset="0x1FF2300", VA="0x1FF2300")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FF2308", Offset="0x1FF2308", VA="0x1FF2308")]
			set
			{
			}
		}

		[Address(RVA="0x1FF29BC", Offset="0x1FF29BC", VA="0x1FF29BC")]
		static ClubDungeonPlayer()
		{
		}

		[Address(RVA="0x1FF21B0", Offset="0x1FF21B0", VA="0x1FF21B0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CA9C", Offset="0x107CA9C")]
		public ClubDungeonPlayer()
		{
		}

		[Address(RVA="0x1FF2208", Offset="0x1FF2208", VA="0x1FF2208")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CAAC", Offset="0x107CAAC")]
		public ClubDungeonPlayer(ClubDungeonPlayer other)
		{
		}

		[Address(RVA="0x1FF2728", Offset="0x1FF2728", VA="0x1FF2728", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CB1C", Offset="0x107CB1C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FF22A0", Offset="0x1FF22A0", VA="0x1FF22A0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CABC", Offset="0x107CABC")]
		public ClubDungeonPlayer Clone()
		{
			return null;
		}

		[Address(RVA="0x1FF2398", Offset="0x1FF2398", VA="0x1FF2398", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CACC", Offset="0x107CACC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FF240C", Offset="0x1FF240C", VA="0x1FF240C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CADC", Offset="0x107CADC")]
		public bool Equals(ClubDungeonPlayer other)
		{
			return new bool();
		}

		[Address(RVA="0x1FF2490", Offset="0x1FF2490", VA="0x1FF2490", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CAEC", Offset="0x107CAEC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FF285C", Offset="0x1FF285C", VA="0x1FF285C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CB2C", Offset="0x107CB2C")]
		public void MergeFrom(ClubDungeonPlayer other)
		{
		}

		[Address(RVA="0x1FF28E0", Offset="0x1FF28E0", VA="0x1FF28E0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CB3C", Offset="0x107CB3C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FF2558", Offset="0x1FF2558", VA="0x1FF2558", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CAFC", Offset="0x107CAFC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FF25C0", Offset="0x1FF25C0", VA="0x1FF25C0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CB0C", Offset="0x107CB0C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F9A8", Offset="0x104F9A8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubDungeonPlayer.<>c <>9;

			[Address(RVA="0x1FF2A94", Offset="0x1FF2A94", VA="0x1FF2A94")]
			static <>c()
			{
			}

			[Address(RVA="0x1FF2AF8", Offset="0x1FF2AF8", VA="0x1FF2AF8")]
			public <>c()
			{
			}

			[Address(RVA="0x1FF2B00", Offset="0x1FF2B00", VA="0x1FF2B00")]
			internal ClubDungeonPlayer <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}