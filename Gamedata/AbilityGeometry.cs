using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct AbilityGeometry : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public float Angle
		{
			[Address(RVA="0xF09AB4", Offset="0xF09AB4", VA="0xF09AB4")]
			get
			{
				return new float();
			}
		}

		public string Asset
		{
			[Address(RVA="0xF09A8C", Offset="0xF09A8C", VA="0xF09A8C")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF09A50", Offset="0xF09A50", VA="0xF09A50", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF09A7C", Offset="0xF09A7C", VA="0xF09A7C")]
			get
			{
				return new ulong();
			}
		}

		public float Length
		{
			[Address(RVA="0xF09AA4", Offset="0xF09AA4", VA="0xF09AA4")]
			get
			{
				return new float();
			}
		}

		public string SequenceAsset
		{
			[Address(RVA="0xF09ABC", Offset="0xF09ABC", VA="0xF09ABC")]
			get
			{
				return null;
			}
		}

		public AbilityShape Shape
		{
			[Address(RVA="0xF09A84", Offset="0xF09A84", VA="0xF09A84")]
			get
			{
				return new AbilityShape();
			}
		}

		public float Width
		{
			[Address(RVA="0xF09AAC", Offset="0xF09AAC", VA="0xF09AAC")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0xF09A64", Offset="0xF09A64", VA="0xF09A64")]
		public AbilityGeometry __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new AbilityGeometry();
		}

		[Address(RVA="0xF09A58", Offset="0xF09A58", VA="0xF09A58", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15ECD18", Offset="0x15ECD18", VA="0x15ECD18")]
		public static void AddAngle(FlatBufferBuilder builder, float angle)
		{
		}

		[Address(RVA="0x15ECDE4", Offset="0x15ECDE4", VA="0x15ECDE4")]
		public static void AddAsset(FlatBufferBuilder builder, StringOffset assetOffset)
		{
		}

		[Address(RVA="0x15ECCA0", Offset="0x15ECCA0", VA="0x15ECCA0")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x15ECDA0", Offset="0x15ECDA0", VA="0x15ECDA0")]
		public static void AddLength(FlatBufferBuilder builder, float length)
		{
		}

		[Address(RVA="0x15ECCDC", Offset="0x15ECCDC", VA="0x15ECCDC")]
		public static void AddSequenceAsset(FlatBufferBuilder builder, StringOffset sequenceAssetOffset)
		{
		}

		[Address(RVA="0x15ECE20", Offset="0x15ECE20", VA="0x15ECE20")]
		public static void AddShape(FlatBufferBuilder builder, AbilityShape shape)
		{
		}

		[Address(RVA="0x15ECD5C", Offset="0x15ECD5C", VA="0x15ECD5C")]
		public static void AddWidth(FlatBufferBuilder builder, float width)
		{
		}

		[Address(RVA="0x15ECBD0", Offset="0x15ECBD0", VA="0x15ECBD0")]
		public static Offset<AbilityGeometry> CreateAbilityGeometry(FlatBufferBuilder builder, ulong id = 0L, AbilityShape shape = 0, StringOffset assetOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.AbilityGeometry> Gamedata.AbilityGeometry::CreateAbilityGeometry(FlatBuffers.FlatBufferBuilder,System.UInt64,Gamedata.AbilityShape,FlatBuffers.StringOffset,System.Single,System.Single,System.Single,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.AbilityGeometry> CreateAbilityGeometry(FlatBuffers.FlatBufferBuilder,System.UInt64,Gamedata.AbilityShape,FlatBuffers.StringOffset,System.Single,System.Single,System.Single,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15ECE5C", Offset="0x15ECE5C", VA="0x15ECE5C")]
		public static Offset<AbilityGeometry> EndAbilityGeometry(FlatBufferBuilder builder)
		{
			return new Offset<AbilityGeometry>();
		}

		[Address(RVA="0x15ECF0C", Offset="0x15ECF0C", VA="0x15ECF0C")]
		public static void FinishAbilityGeometryBuffer(FlatBufferBuilder builder, Offset<AbilityGeometry> offset)
		{
		}

		[Address(RVA="0xF09A94", Offset="0xF09A94", VA="0xF09A94")]
		public ArraySegment<byte>? GetAssetBytes()
		{
			return null;
		}

		[Address(RVA="0x15EC834", Offset="0x15EC834", VA="0x15EC834")]
		public static AbilityGeometry GetRootAsAbilityGeometry(FlatBuffers.ByteBuffer _bb)
		{
			return new AbilityGeometry();
		}

		[Address(RVA="0x15EC840", Offset="0x15EC840", VA="0x15EC840")]
		public static AbilityGeometry GetRootAsAbilityGeometry(FlatBuffers.ByteBuffer _bb, AbilityGeometry obj)
		{
			return new AbilityGeometry();
		}

		[Address(RVA="0xF09AC4", Offset="0xF09AC4", VA="0xF09AC4")]
		public ArraySegment<byte>? GetSequenceAssetBytes()
		{
			return null;
		}

		[Address(RVA="0x15ECEDC", Offset="0x15ECEDC", VA="0x15ECEDC")]
		public static void StartAbilityGeometry(FlatBufferBuilder builder)
		{
		}
	}
}