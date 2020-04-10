using Il2CppDummyDll;
using System;
using System.IO;

namespace UTNotifications
{
	public class JSONData : JSONNode
	{
		[FieldOffset(Offset="0x10")]
		private string m_Data;

		public override string Value
		{
			[Address(RVA="0x1442A0C", Offset="0x1442A0C", VA="0x1442A0C", Slot="9")]
			get
			{
				return null;
			}
			[Address(RVA="0x1442A14", Offset="0x1442A14", VA="0x1442A14", Slot="10")]
			set
			{
			}
		}

		[Address(RVA="0x1442A1C", Offset="0x1442A1C", VA="0x1442A1C")]
		public JSONData(string aData)
		{
		}

		[Address(RVA="0x1442A48", Offset="0x1442A48", VA="0x1442A48")]
		public JSONData(float aData)
		{
		}

		[Address(RVA="0x1442A8C", Offset="0x1442A8C", VA="0x1442A8C")]
		public JSONData(double aData)
		{
		}

		[Address(RVA="0x1442AD0", Offset="0x1442AD0", VA="0x1442AD0")]
		public JSONData(bool aData)
		{
		}

		[Address(RVA="0x1442B0C", Offset="0x1442B0C", VA="0x1442B0C")]
		public JSONData(int aData)
		{
		}

		[Address(RVA="0x1442C10", Offset="0x1442C10", VA="0x1442C10", Slot="28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Address(RVA="0x1442B48", Offset="0x1442B48", VA="0x1442B48", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1442BAC", Offset="0x1442BAC", VA="0x1442BAC", Slot="17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}
	}
}