using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class UpdateClubRequest : IMessage<UpdateClubRequest>, IMessage, IEquatable<UpdateClubRequest>, IDeepCloneable<UpdateClubRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<UpdateClubRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string id_;

		[FieldOffset(Offset="0x0")]
		public const int SettingsFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ClubSettings settings_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094D30", Offset="0x1094D30")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x14B6C48", Offset="0x14B6C48", VA="0x14B6C48")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094D50", Offset="0x1094D50")]
		public string Id
		{
			[Address(RVA="0x14B6ED0", Offset="0x14B6ED0", VA="0x14B6ED0")]
			get
			{
				return null;
			}
			[Address(RVA="0x14B6ED8", Offset="0x14B6ED8", VA="0x14B6ED8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094D20", Offset="0x1094D20")]
		public static MessageParser<UpdateClubRequest> Parser
		{
			[Address(RVA="0x14B6BE0", Offset="0x14B6BE0", VA="0x14B6BE0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094D40", Offset="0x1094D40")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x14B6D38", Offset="0x14B6D38", VA="0x14B6D38", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094D60", Offset="0x1094D60")]
		public ClubSettings Settings
		{
			[Address(RVA="0x14B6E60", Offset="0x14B6E60", VA="0x14B6E60")]
			get
			{
				return null;
			}
			[Address(RVA="0x14B6E68", Offset="0x14B6E68", VA="0x14B6E68")]
			set
			{
			}
		}

		[Address(RVA="0x14B752C", Offset="0x14B752C", VA="0x14B752C")]
		static UpdateClubRequest()
		{
		}

		[Address(RVA="0x14B6D94", Offset="0x14B6D94", VA="0x14B6D94")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AFCC", Offset="0x107AFCC")]
		public UpdateClubRequest()
		{
		}

		[Address(RVA="0x14B6DEC", Offset="0x14B6DEC", VA="0x14B6DEC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AFDC", Offset="0x107AFDC")]
		public UpdateClubRequest(UpdateClubRequest other)
		{
		}

		[Address(RVA="0x14B7248", Offset="0x14B7248", VA="0x14B7248", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B04C", Offset="0x107B04C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x14B6E70", Offset="0x14B6E70", VA="0x14B6E70", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AFEC", Offset="0x107AFEC")]
		public UpdateClubRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x14B6F48", Offset="0x14B6F48", VA="0x14B6F48", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AFFC", Offset="0x107AFFC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x14B6FBC", Offset="0x14B6FBC", VA="0x14B6FBC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B00C", Offset="0x107B00C")]
		public bool Equals(UpdateClubRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x14B7034", Offset="0x14B7034", VA="0x14B7034", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B01C", Offset="0x107B01C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x14B7340", Offset="0x14B7340", VA="0x14B7340", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B05C", Offset="0x107B05C")]
		public void MergeFrom(UpdateClubRequest other)
		{
		}

		[Address(RVA="0x14B7420", Offset="0x14B7420", VA="0x14B7420", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B06C", Offset="0x107B06C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x14B70D0", Offset="0x14B70D0", VA="0x14B70D0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B02C", Offset="0x107B02C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x14B7138", Offset="0x14B7138", VA="0x14B7138", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B03C", Offset="0x107B03C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F738", Offset="0x104F738")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static UpdateClubRequest.<>c <>9;

			[Address(RVA="0x14B7604", Offset="0x14B7604", VA="0x14B7604")]
			static <>c()
			{
			}

			[Address(RVA="0x14B7668", Offset="0x14B7668", VA="0x14B7668")]
			public <>c()
			{
			}

			[Address(RVA="0x14B7670", Offset="0x14B7670", VA="0x14B7670")]
			internal UpdateClubRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}