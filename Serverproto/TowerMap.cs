using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class TowerMap : IMessage<TowerMap>, IMessage, IEquatable<TowerMap>, IDeepCloneable<TowerMap>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<TowerMap> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private TowerIdentifier id_;

		[FieldOffset(Offset="0x0")]
		public const int NodesFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<TowerNode> _repeated_nodes_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<TowerNode> nodes_;

		[FieldOffset(Offset="0x0")]
		public const int RequiredCompletionCountFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong requiredCompletionCount_;

		[FieldOffset(Offset="0x0")]
		public const int ImageFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string image_;

		[FieldOffset(Offset="0x0")]
		public const int SceneFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private string scene_;

		[FieldOffset(Offset="0x0")]
		public const int NameKeyFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private string nameKey_;

		[FieldOffset(Offset="0x0")]
		public const int DescriptionKeyFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private string descriptionKey_;

		[FieldOffset(Offset="0x0")]
		public const int ShowcaseItemsFieldNumber = 8;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ulong> _repeated_showcaseItems_codec;

		[FieldOffset(Offset="0x50")]
		private readonly RepeatedField<ulong> showcaseItems_;

		[FieldOffset(Offset="0x0")]
		public const int ProgressionRewardsFieldNumber = 9;

		[FieldOffset(Offset="0x18")]
		private readonly static FieldCodec<ItemCountRange> _repeated_progressionRewards_codec;

		[FieldOffset(Offset="0x58")]
		private readonly RepeatedField<ItemCountRange> progressionRewards_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CD58", Offset="0x109CD58")]
		public string DescriptionKey
		{
			[Address(RVA="0x1B72314", Offset="0x1B72314", VA="0x1B72314")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B7231C", Offset="0x1B7231C", VA="0x1B7231C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CCD8", Offset="0x109CCD8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B71DCC", Offset="0x1B71DCC", VA="0x1B71DCC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CCF8", Offset="0x109CCF8")]
		public TowerIdentifier Id
		{
			[Address(RVA="0x1B72124", Offset="0x1B72124", VA="0x1B72124")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B7212C", Offset="0x1B7212C", VA="0x1B7212C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CD28", Offset="0x109CD28")]
		public string Image
		{
			[Address(RVA="0x1B721AC", Offset="0x1B721AC", VA="0x1B721AC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B721B4", Offset="0x1B721B4", VA="0x1B721B4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CD48", Offset="0x109CD48")]
		public string NameKey
		{
			[Address(RVA="0x1B7229C", Offset="0x1B7229C", VA="0x1B7229C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B722A4", Offset="0x1B722A4", VA="0x1B722A4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CD08", Offset="0x109CD08")]
		public RepeatedField<TowerNode> Nodes
		{
			[Address(RVA="0x1B72194", Offset="0x1B72194", VA="0x1B72194")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CCC8", Offset="0x109CCC8")]
		public static MessageParser<TowerMap> Parser
		{
			[Address(RVA="0x1B6D2D8", Offset="0x1B6D2D8", VA="0x1B6D2D8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CCE8", Offset="0x109CCE8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B71EB8", Offset="0x1B71EB8", VA="0x1B71EB8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CD78", Offset="0x109CD78")]
		public RepeatedField<ItemCountRange> ProgressionRewards
		{
			[Address(RVA="0x1B72394", Offset="0x1B72394", VA="0x1B72394")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CD18", Offset="0x109CD18")]
		public ulong RequiredCompletionCount
		{
			[Address(RVA="0x1B7219C", Offset="0x1B7219C", VA="0x1B7219C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B721A4", Offset="0x1B721A4", VA="0x1B721A4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CD38", Offset="0x109CD38")]
		public string Scene
		{
			[Address(RVA="0x1B72224", Offset="0x1B72224", VA="0x1B72224")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B7222C", Offset="0x1B7222C", VA="0x1B7222C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CD68", Offset="0x109CD68")]
		public RepeatedField<ulong> ShowcaseItems
		{
			[Address(RVA="0x1B7238C", Offset="0x1B7238C", VA="0x1B7238C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B733D8", Offset="0x1B733D8", VA="0x1B733D8")]
		static TowerMap()
		{
		}

		[Address(RVA="0x1B71F14", Offset="0x1B71F14", VA="0x1B71F14")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10894FC", Offset="0x10894FC")]
		public TowerMap()
		{
		}

		[Address(RVA="0x1B71FE8", Offset="0x1B71FE8", VA="0x1B71FE8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108950C", Offset="0x108950C")]
		public TowerMap(TowerMap other)
		{
		}

		[Address(RVA="0x1B72BC4", Offset="0x1B72BC4", VA="0x1B72BC4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108957C", Offset="0x108957C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B72134", Offset="0x1B72134", VA="0x1B72134", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108951C", Offset="0x108951C")]
		public TowerMap Clone()
		{
			return null;
		}

		[Address(RVA="0x1B7239C", Offset="0x1B7239C", VA="0x1B7239C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108952C", Offset="0x108952C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B72410", Offset="0x1B72410", VA="0x1B72410", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108953C", Offset="0x108953C")]
		public bool Equals(TowerMap other)
		{
			return new bool();
		}

		[Address(RVA="0x1B72594", Offset="0x1B72594", VA="0x1B72594", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108954C", Offset="0x108954C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B72EEC", Offset="0x1B72EEC", VA="0x1B72EEC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108958C", Offset="0x108958C")]
		public void MergeFrom(TowerMap other)
		{
		}

		[Address(RVA="0x1B730DC", Offset="0x1B730DC", VA="0x1B730DC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108959C", Offset="0x108959C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B72794", Offset="0x1B72794", VA="0x1B72794", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108955C", Offset="0x108955C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B727FC", Offset="0x1B727FC", VA="0x1B727FC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108956C", Offset="0x108956C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050C28", Offset="0x1050C28")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static TowerMap.<>c <>9;

			[Address(RVA="0x1B7355C", Offset="0x1B7355C", VA="0x1B7355C")]
			static <>c()
			{
			}

			[Address(RVA="0x1B735C0", Offset="0x1B735C0", VA="0x1B735C0")]
			public <>c()
			{
			}

			[Address(RVA="0x1B735C8", Offset="0x1B735C8", VA="0x1B735C8")]
			internal TowerMap <.cctor>b__65_0()
			{
				return null;
			}
		}
	}
}