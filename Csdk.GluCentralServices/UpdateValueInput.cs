using Il2CppDummyDll;
using System;

namespace Csdk.GluCentralServices
{
	public class UpdateValueInput
	{
		[FieldOffset(Offset="0x10")]
		internal string mName;

		[FieldOffset(Offset="0x18")]
		internal string mColType;

		[FieldOffset(Offset="0x20")]
		internal string mMapKey;

		[FieldOffset(Offset="0x28")]
		internal string mValType;

		[FieldOffset(Offset="0x30")]
		internal string mVal;

		[FieldOffset(Offset="0x38")]
		internal string mOp;

		[Address(RVA="0x21DC980", Offset="0x21DC980", VA="0x21DC980")]
		public UpdateValueInput(string name)
		{
		}

		[Address(RVA="0x21DFA98", Offset="0x21DFA98", VA="0x21DFA98")]
		public UpdateValueInput ColMap(string mapKey)
		{
			return null;
		}

		[Address(RVA="0x21DFB40", Offset="0x21DFB40", VA="0x21DFB40")]
		private UpdateValueInput DoCol(string colType, string mapKey)
		{
			return null;
		}

		[Address(RVA="0x21DCA24", Offset="0x21DCA24", VA="0x21DCA24")]
		internal UpdateValueInput DoOp(string op)
		{
			return null;
		}

		[Address(RVA="0x21DF6D0", Offset="0x21DF6D0", VA="0x21DF6D0")]
		private UpdateValueInput DoVal(string valType, string val)
		{
			return null;
		}

		[Address(RVA="0x21DF99C", Offset="0x21DF99C", VA="0x21DF99C")]
		public UpdateValueInput OpDecrement()
		{
			return null;
		}

		[Address(RVA="0x21DF948", Offset="0x21DF948", VA="0x21DF948")]
		public UpdateValueInput OpIncrement()
		{
			return null;
		}

		[Address(RVA="0x21DFA44", Offset="0x21DFA44", VA="0x21DFA44")]
		public UpdateValueInput OpMax()
		{
			return null;
		}

		[Address(RVA="0x21DF9F0", Offset="0x21DF9F0", VA="0x21DF9F0")]
		public UpdateValueInput OpMin()
		{
			return null;
		}

		[Address(RVA="0x21DF8A0", Offset="0x21DF8A0", VA="0x21DF8A0")]
		public UpdateValueInput OpSet()
		{
			return null;
		}

		[Address(RVA="0x21DF8F4", Offset="0x21DF8F4", VA="0x21DF8F4")]
		public UpdateValueInput OpSetOnce()
		{
			return null;
		}

		[Address(RVA="0x21DCCA8", Offset="0x21DCCA8", VA="0x21DCCA8")]
		public UpdateValueInput ValBool(bool val)
		{
			return null;
		}

		[Address(RVA="0x21DCC10", Offset="0x21DCC10", VA="0x21DCC10")]
		public UpdateValueInput ValNumberFromDecimal(decimal val)
		{
			return null;
		}

		[Address(RVA="0x21DCB6C", Offset="0x21DCB6C", VA="0x21DCB6C")]
		public UpdateValueInput ValNumberFromDouble(double val)
		{
			return null;
		}

		[Address(RVA="0x21DCAD4", Offset="0x21DCAD4", VA="0x21DCAD4")]
		public UpdateValueInput ValNumberFromInt64(long val)
		{
			return null;
		}

		[Address(RVA="0x21DCA2C", Offset="0x21DCA2C", VA="0x21DCA2C")]
		public UpdateValueInput ValString(string val)
		{
			return null;
		}

		[Address(RVA="0x21DCD30", Offset="0x21DCD30", VA="0x21DCD30")]
		public UpdateValueInput ValTimestamp(DateTime val)
		{
			return null;
		}

		[Address(RVA="0x21DF780", Offset="0x21DF780", VA="0x21DF780")]
		public UpdateValueInput ValTimestampFromUnixMS(long val)
		{
			return null;
		}

		[Address(RVA="0x21DCD94", Offset="0x21DCD94", VA="0x21DCD94")]
		public UpdateValueInput ValVersion(Version val)
		{
			return null;
		}

		[Address(RVA="0x21DF6D8", Offset="0x21DF6D8", VA="0x21DF6D8")]
		public UpdateValueInput ValVersionFromString(string val)
		{
			return null;
		}
	}
}