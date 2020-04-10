using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Polybrush
{
	[Serializable]
	public class z_AttributeLayout : IEquatable<z_AttributeLayout>
	{
		[FieldOffset(Offset="0x0")]
		public const int NoMask = -1;

		[FieldOffset(Offset="0x0")]
		public const int DefaultMask = 0;

		[FieldOffset(Offset="0x0")]
		public readonly static int[] DefaultMaskValues;

		[FieldOffset(Offset="0x8")]
		public readonly static GUIContent[] DefaultMaskDescriptions;

		[FieldOffset(Offset="0x10")]
		public readonly static Vector2 NormalizedRange;

		[FieldOffset(Offset="0x10")]
		public z_MeshChannel channel;

		[FieldOffset(Offset="0x14")]
		public z_ComponentIndex index;

		[FieldOffset(Offset="0x18")]
		public Vector2 range;

		[FieldOffset(Offset="0x20")]
		public string propertyTarget;

		[FieldOffset(Offset="0x28")]
		public int mask;

		[FieldOffset(Offset="0x30")]
		[NonSerialized]
		public Texture2D previewTexture;

		public float max
		{
			[Address(RVA="0x134595C", Offset="0x134595C", VA="0x134595C")]
			get
			{
				return new float();
			}
			[Address(RVA="0x1345964", Offset="0x1345964", VA="0x1345964")]
			set
			{
			}
		}

		public float min
		{
			[Address(RVA="0x134594C", Offset="0x134594C", VA="0x134594C")]
			get
			{
				return new float();
			}
			[Address(RVA="0x1345954", Offset="0x1345954", VA="0x1345954")]
			set
			{
			}
		}

		[Address(RVA="0x1345FD4", Offset="0x1345FD4", VA="0x1345FD4")]
		static z_AttributeLayout()
		{
		}

		[Address(RVA="0x134596C", Offset="0x134596C", VA="0x134596C")]
		public z_AttributeLayout(z_MeshChannel channel, z_ComponentIndex index)
		{
		}

		[Address(RVA="0x13459F4", Offset="0x13459F4", VA="0x13459F4")]
		public z_AttributeLayout(z_MeshChannel channel, z_ComponentIndex index, Vector2 range, int mask)
		{
		}

		[Address(RVA="0x1345A74", Offset="0x1345A74", VA="0x1345A74")]
		public z_AttributeLayout(z_MeshChannel channel, z_ComponentIndex index, Vector2 range, int mask, string targetProperty, Texture2D texture = // 
		// Current member / type: System.Void Polybrush.z_AttributeLayout::.ctor(Polybrush.z_MeshChannel,Polybrush.z_ComponentIndex,UnityEngine.Vector2,System.Int32,System.String,UnityEngine.Texture2D)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void .ctor(Polybrush.z_MeshChannel,Polybrush.z_ComponentIndex,UnityEngine.Vector2,System.Int32,System.String,UnityEngine.Texture2D)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x1345AAC", Offset="0x1345AAC", VA="0x1345AAC", Slot="4")]
		public bool Equals(z_AttributeLayout other)
		{
			return new bool();
		}

		[Address(RVA="0x1345BB8", Offset="0x1345BB8", VA="0x1345BB8", Slot="3")]
		public override string ToString()
		{
			return null;
		}
	}
}