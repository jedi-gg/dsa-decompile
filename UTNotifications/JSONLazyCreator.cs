using Il2CppDummyDll;
using System;

namespace UTNotifications
{
	[Attribute(Name="DefaultMemberAttribute", RVA="0x1049598", Offset="0x1049598")]
	internal class JSONLazyCreator : JSONNode
	{
		[FieldOffset(Offset="0x10")]
		private JSONNode m_Node;

		[FieldOffset(Offset="0x18")]
		private string m_Key;

		public override JSONArray AsArray
		{
			[Address(RVA="0x14437F8", Offset="0x14437F8", VA="0x14437F8", Slot="26")]
			get
			{
				return null;
			}
		}

		public override bool AsBool
		{
			[Address(RVA="0x14436EC", Offset="0x14436EC", VA="0x14436EC", Slot="24")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1443770", Offset="0x1443770", VA="0x1443770", Slot="25")]
			set
			{
			}
		}

		public override double AsDouble
		{
			[Address(RVA="0x14435E0", Offset="0x14435E0", VA="0x14435E0", Slot="22")]
			get
			{
				return new double();
			}
			[Address(RVA="0x1443664", Offset="0x1443664", VA="0x1443664", Slot="23")]
			set
			{
			}
		}

		public override float AsFloat
		{
			[Address(RVA="0x14434D4", Offset="0x14434D4", VA="0x14434D4", Slot="20")]
			get
			{
				return new float();
			}
			[Address(RVA="0x1443558", Offset="0x1443558", VA="0x1443558", Slot="21")]
			set
			{
			}
		}

		public override int AsInt
		{
			[Address(RVA="0x14433C8", Offset="0x14433C8", VA="0x14433C8", Slot="18")]
			get
			{
				return new int();
			}
			[Address(RVA="0x144344C", Offset="0x144344C", VA="0x144344C", Slot="19")]
			set
			{
			}
		}

		public override JSONClass AsObject
		{
			[Address(RVA="0x1443860", Offset="0x1443860", VA="0x1443860", Slot="27")]
			get
			{
				return null;
			}
		}

		public override JSONNode Item(int aIndex)
		{
			[Address(RVA="0x1442FCC", Offset="0x1442FCC", VA="0x1442FCC", Slot="5")]
			get
			{
				return null;
			}
			[Address(RVA="0x1443030", Offset="0x1443030", VA="0x1443030", Slot="6")]
			set
			{
			}
		}

		public override JSONNode Item(string aKey)
		{
			[Address(RVA="0x14430BC", Offset="0x14430BC", VA="0x14430BC", Slot="7")]
			get
			{
				return null;
			}
			[Address(RVA="0x144312C", Offset="0x144312C", VA="0x144312C", Slot="8")]
			set
			{
			}
		}

		[Address(RVA="0x143FC44", Offset="0x143FC44", VA="0x143FC44")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Address(RVA="0x1440D80", Offset="0x1440D80", VA="0x1440D80")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Address(RVA="0x14431C0", Offset="0x14431C0", VA="0x14431C0", Slot="12")]
		public override void Add(JSONNode aItem)
		{
		}

		[Address(RVA="0x144324C", Offset="0x144324C", VA="0x144324C", Slot="4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Address(RVA="0x1443310", Offset="0x1443310", VA="0x1443310", Slot="0")]
		public override bool Equals(object obj)
		{
			return new bool();
		}

		[Address(RVA="0x1443328", Offset="0x1443328", VA="0x1443328", Slot="2")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x14432E0", Offset="0x14432E0", VA="0x14432E0")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return new bool();
		}

		[Address(RVA="0x14432F8", Offset="0x14432F8", VA="0x14432F8")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return new bool();
		}

		[Address(RVA="0x1442F50", Offset="0x1442F50", VA="0x1442F50")]
		private void Set(JSONNode aVal)
		{
		}

		[Address(RVA="0x1443338", Offset="0x1443338", VA="0x1443338", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1443380", Offset="0x1443380", VA="0x1443380", Slot="17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}
	}
}