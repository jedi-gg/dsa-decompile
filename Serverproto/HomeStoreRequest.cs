using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeStoreRequest : IMessage<HomeStoreRequest>, IMessage, IEquatable<HomeStoreRequest>, IDeepCloneable<HomeStoreRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeStoreRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097D18", Offset="0x1097D18")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18D678C", Offset="0x18D678C", VA="0x18D678C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097D08", Offset="0x1097D08")]
		public static MessageParser<HomeStoreRequest> Parser
		{
			[Address(RVA="0x18D6724", Offset="0x18D6724", VA="0x18D6724")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097D28", Offset="0x1097D28")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18D687C", Offset="0x18D687C", VA="0x18D687C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18D6B90", Offset="0x18D6B90", VA="0x18D6B90")]
		static HomeStoreRequest()
		{
		}

		[Address(RVA="0x18D68D8", Offset="0x18D68D8", VA="0x18D68D8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108092C", Offset="0x108092C")]
		public HomeStoreRequest()
		{
		}

		[Address(RVA="0x18D68E0", Offset="0x18D68E0", VA="0x18D68E0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108093C", Offset="0x108093C")]
		public HomeStoreRequest(HomeStoreRequest other)
		{
		}

		[Address(RVA="0x18D6AF4", Offset="0x18D6AF4", VA="0x18D6AF4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10809AC", Offset="0x10809AC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18D6924", Offset="0x18D6924", VA="0x18D6924", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108094C", Offset="0x108094C")]
		public HomeStoreRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x18D6984", Offset="0x18D6984", VA="0x18D6984", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108095C", Offset="0x108095C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18D6A1C", Offset="0x18D6A1C", VA="0x18D6A1C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108096C", Offset="0x108096C")]
		public bool Equals(HomeStoreRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x18D6A48", Offset="0x18D6A48", VA="0x18D6A48", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108097C", Offset="0x108097C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18D6B08", Offset="0x18D6B08", VA="0x18D6B08", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10809BC", Offset="0x10809BC")]
		public void MergeFrom(HomeStoreRequest other)
		{
		}

		[Address(RVA="0x18D6B3C", Offset="0x18D6B3C", VA="0x18D6B3C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10809CC", Offset="0x10809CC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18D6A78", Offset="0x18D6A78", VA="0x18D6A78", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108098C", Offset="0x108098C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18D6AE0", Offset="0x18D6AE0", VA="0x18D6AE0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108099C", Offset="0x108099C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FF68", Offset="0x104FF68")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeStoreRequest.<>c <>9;

			[Address(RVA="0x18D6C68", Offset="0x18D6C68", VA="0x18D6C68")]
			static <>c()
			{
			}

			[Address(RVA="0x18D6CCC", Offset="0x18D6CCC", VA="0x18D6CCC")]
			public <>c()
			{
			}

			[Address(RVA="0x18D6CD4", Offset="0x18D6CD4", VA="0x18D6CD4")]
			internal HomeStoreRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}