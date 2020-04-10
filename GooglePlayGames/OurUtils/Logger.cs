using Il2CppDummyDll;
using System;

namespace GooglePlayGames.OurUtils
{
	public class Logger
	{
		[FieldOffset(Offset="0x0")]
		private static bool debugLogEnabled;

		[FieldOffset(Offset="0x1")]
		private static bool warningLogEnabled;

		public static bool DebugLogEnabled
		{
			[Address(RVA="0x12D3EDC", Offset="0x12D3EDC", VA="0x12D3EDC")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x12D3F44", Offset="0x12D3F44", VA="0x12D3F44")]
			set
			{
			}
		}

		public static bool WarningLogEnabled
		{
			[Address(RVA="0x12D3FB4", Offset="0x12D3FB4", VA="0x12D3FB4")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x12D401C", Offset="0x12D401C", VA="0x12D401C")]
			set
			{
			}
		}

		[Address(RVA="0x12D473C", Offset="0x12D473C", VA="0x12D473C")]
		static Logger()
		{
		}

		[Address(RVA="0x12D4734", Offset="0x12D4734", VA="0x12D4734")]
		public Logger()
		{
		}

		[Address(RVA="0x12D3DE4", Offset="0x12D3DE4", VA="0x12D3DE4")]
		public static void d(string msg)
		{
		}

		[Address(RVA="0x12D435C", Offset="0x12D435C", VA="0x12D435C")]
		public static string describe(byte[] b)
		{
			return null;
		}

		[Address(RVA="0x12D425C", Offset="0x12D425C", VA="0x12D425C")]
		public static void e(string msg)
		{
		}

		[Address(RVA="0x12D43FC", Offset="0x12D43FC", VA="0x12D43FC")]
		private static string ToLogMessage(string prefix, string logType, string msg)
		{
			return null;
		}

		[Address(RVA="0x12D3028", Offset="0x12D3028", VA="0x12D3028")]
		public static void w(string msg)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104ED28", Offset="0x104ED28")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static Logger.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Action <>9__12_0;

			[Address(RVA="0x12D479C", Offset="0x12D479C", VA="0x12D479C")]
			static <>c()
			{
			}

			[Address(RVA="0x12D4800", Offset="0x12D4800", VA="0x12D4800")]
			public <>c()
			{
			}

			[Address(RVA="0x12D4808", Offset="0x12D4808", VA="0x12D4808")]
			internal void <ToLogMessage>b__12_0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104ED18", Offset="0x104ED18")]
		private sealed class <>c__DisplayClass10_0
		{
			[FieldOffset(Offset="0x10")]
			public string msg;

			[Address(RVA="0x12D4354", Offset="0x12D4354", VA="0x12D4354")]
			public <>c__DisplayClass10_0()
			{
			}

			[Address(RVA="0x12D4874", Offset="0x12D4874", VA="0x12D4874")]
			internal void <e>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104ECF8", Offset="0x104ECF8")]
		private sealed class <>c__DisplayClass8_0
		{
			[FieldOffset(Offset="0x10")]
			public string msg;

			[Address(RVA="0x12D408C", Offset="0x12D408C", VA="0x12D408C")]
			public <>c__DisplayClass8_0()
			{
			}

			[Address(RVA="0x12D4928", Offset="0x12D4928", VA="0x12D4928")]
			internal void <d>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104ED08", Offset="0x104ED08")]
		private sealed class <>c__DisplayClass9_0
		{
			[FieldOffset(Offset="0x10")]
			public string msg;

			[Address(RVA="0x12D4254", Offset="0x12D4254", VA="0x12D4254")]
			public <>c__DisplayClass9_0()
			{
			}

			[Address(RVA="0x12D49E8", Offset="0x12D49E8", VA="0x12D49E8")]
			internal void <w>b__0()
			{
			}
		}
	}
}