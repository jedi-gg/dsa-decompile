using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct BattleMessage : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public string BodyText
		{
			[Address(RVA="0xF0A66C", Offset="0xF0A66C", VA="0xF0A66C")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0A630", Offset="0xF0A630", VA="0xF0A630", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF0A65C", Offset="0xF0A65C", VA="0xF0A65C")]
			get
			{
				return new ulong();
			}
		}

		public BattleMessagePause Pause
		{
			[Address(RVA="0xF0A6BC", Offset="0xF0A6BC", VA="0xF0A6BC")]
			get
			{
				return new BattleMessagePause();
			}
		}

		public string PointAtId
		{
			[Address(RVA="0xF0A69C", Offset="0xF0A69C", VA="0xF0A69C")]
			get
			{
				return null;
			}
		}

		public bool PointAtTapAnywhere
		{
			[Address(RVA="0xF0A6B4", Offset="0xF0A6B4", VA="0xF0A6B4")]
			get
			{
				return new bool();
			}
		}

		public string PointAtView
		{
			[Address(RVA="0xF0A684", Offset="0xF0A684", VA="0xF0A684")]
			get
			{
				return null;
			}
		}

		public SeekerPointAt? SeekerData
		{
			[Address(RVA="0xF0A6C4", Offset="0xF0A6C4", VA="0xF0A6C4")]
			get
			{
				return null;
			}
		}

		public BattleMessageType Type
		{
			[Address(RVA="0xF0A664", Offset="0xF0A664", VA="0xF0A664")]
			get
			{
				return new BattleMessageType();
			}
		}

		[Address(RVA="0xF0A644", Offset="0xF0A644", VA="0xF0A644")]
		public BattleMessage __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new BattleMessage();
		}

		[Address(RVA="0xF0A638", Offset="0xF0A638", VA="0xF0A638", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15F2E9C", Offset="0x15F2E9C", VA="0x15F2E9C")]
		public static void AddBodyText(FlatBufferBuilder builder, StringOffset bodyTextOffset)
		{
		}

		[Address(RVA="0x15F2DAC", Offset="0x15F2DAC", VA="0x15F2DAC")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x15F2ED8", Offset="0x15F2ED8", VA="0x15F2ED8")]
		public static void AddPause(FlatBufferBuilder builder, BattleMessagePause pause)
		{
		}

		[Address(RVA="0x15F2E24", Offset="0x15F2E24", VA="0x15F2E24")]
		public static void AddPointAtId(FlatBufferBuilder builder, StringOffset pointAtIdOffset)
		{
		}

		[Address(RVA="0x15F2F14", Offset="0x15F2F14", VA="0x15F2F14")]
		public static void AddPointAtTapAnywhere(FlatBufferBuilder builder, bool pointAtTapAnywhere)
		{
		}

		[Address(RVA="0x15F2E60", Offset="0x15F2E60", VA="0x15F2E60")]
		public static void AddPointAtView(FlatBufferBuilder builder, StringOffset pointAtViewOffset)
		{
		}

		[Address(RVA="0x15F2DE8", Offset="0x15F2DE8", VA="0x15F2DE8")]
		public static void AddSeekerData(FlatBufferBuilder builder, Offset<SeekerPointAt> seekerDataOffset)
		{
		}

		[Address(RVA="0x15F2F50", Offset="0x15F2F50", VA="0x15F2F50")]
		public static void AddType(FlatBufferBuilder builder, BattleMessageType type)
		{
		}

		[Address(RVA="0x15F2CCC", Offset="0x15F2CCC", VA="0x15F2CCC")]
		public static Offset<BattleMessage> CreateBattleMessage(FlatBufferBuilder builder, ulong id = 0L, BattleMessageType type = 0, StringOffset body_textOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.BattleMessage> Gamedata.BattleMessage::CreateBattleMessage(FlatBuffers.FlatBufferBuilder,System.UInt64,Gamedata.BattleMessageType,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Boolean,Gamedata.BattleMessagePause,FlatBuffers.Offset`1<Gamedata.SeekerPointAt>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.BattleMessage> CreateBattleMessage(FlatBuffers.FlatBufferBuilder,System.UInt64,Gamedata.BattleMessageType,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Boolean,Gamedata.BattleMessagePause,FlatBuffers.Offset<Gamedata.SeekerPointAt>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15F2F8C", Offset="0x15F2F8C", VA="0x15F2F8C")]
		public static Offset<BattleMessage> EndBattleMessage(FlatBufferBuilder builder)
		{
			return new Offset<BattleMessage>();
		}

		[Address(RVA="0x15F303C", Offset="0x15F303C", VA="0x15F303C")]
		public static void FinishBattleMessageBuffer(FlatBufferBuilder builder, Offset<BattleMessage> offset)
		{
		}

		[Address(RVA="0xF0A674", Offset="0xF0A674", VA="0xF0A674")]
		public ArraySegment<byte>? GetBodyTextBytes()
		{
			return null;
		}

		[Address(RVA="0xF0A6A4", Offset="0xF0A6A4", VA="0xF0A6A4")]
		public ArraySegment<byte>? GetPointAtIdBytes()
		{
			return null;
		}

		[Address(RVA="0xF0A68C", Offset="0xF0A68C", VA="0xF0A68C")]
		public ArraySegment<byte>? GetPointAtViewBytes()
		{
			return null;
		}

		[Address(RVA="0x15F2880", Offset="0x15F2880", VA="0x15F2880")]
		public static BattleMessage GetRootAsBattleMessage(FlatBuffers.ByteBuffer _bb)
		{
			return new BattleMessage();
		}

		[Address(RVA="0x15F288C", Offset="0x15F288C", VA="0x15F288C")]
		public static BattleMessage GetRootAsBattleMessage(FlatBuffers.ByteBuffer _bb, BattleMessage obj)
		{
			return new BattleMessage();
		}

		[Address(RVA="0x15F300C", Offset="0x15F300C", VA="0x15F300C")]
		public static void StartBattleMessage(FlatBufferBuilder builder)
		{
		}
	}
}