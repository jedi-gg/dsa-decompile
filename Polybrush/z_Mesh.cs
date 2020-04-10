using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Polybrush
{
	public class z_Mesh
	{
		[FieldOffset(Offset="0x10")]
		public string name;

		[FieldOffset(Offset="0x18")]
		public Vector3[] vertices;

		[FieldOffset(Offset="0x20")]
		public Vector3[] normals;

		[FieldOffset(Offset="0x28")]
		public Color32[] colors;

		[FieldOffset(Offset="0x30")]
		public Vector4[] tangents;

		[FieldOffset(Offset="0x38")]
		public List<Vector4> uv0;

		[FieldOffset(Offset="0x40")]
		public List<Vector4> uv1;

		[FieldOffset(Offset="0x48")]
		public List<Vector4> uv2;

		[FieldOffset(Offset="0x50")]
		public List<Vector4> uv3;

		[FieldOffset(Offset="0x58")]
		private int _subMeshCount;

		[FieldOffset(Offset="0x60")]
		private int[] triangles;

		[FieldOffset(Offset="0x68")]
		private int[][] indices;

		[FieldOffset(Offset="0x70")]
		private MeshTopology[] meshTopology;

		public int subMeshCount
		{
			[Address(RVA="0x1270A10", Offset="0x1270A10", VA="0x1270A10")]
			get
			{
				return new int();
			}
			[Address(RVA="0x1270A18", Offset="0x1270A18", VA="0x1270A18")]
			set
			{
			}
		}

		public int vertexCount
		{
			[Address(RVA="0x1270AE4", Offset="0x1270AE4", VA="0x1270AE4")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0x12716DC", Offset="0x12716DC", VA="0x12716DC")]
		public z_Mesh()
		{
		}

		[Address(RVA="0x1271418", Offset="0x1271418", VA="0x1271418")]
		public void ApplyAttributesToUnityMesh(Mesh m, z_MeshChannel attrib = 255)
		{
		}

		[Address(RVA="0x1270B8C", Offset="0x1270B8C", VA="0x1270B8C")]
		public void Clear()
		{
		}

		[Address(RVA="0x1270CDC", Offset="0x1270CDC", VA="0x1270CDC")]
		public int[] GetIndices(int index)
		{
			return null;
		}

		[Address(RVA="0x12709BC", Offset="0x12709BC", VA="0x12709BC")]
		public MeshTopology GetTopology(int index)
		{
			return new MeshTopology();
		}

		[Address(RVA="0x1270BC4", Offset="0x1270BC4", VA="0x1270BC4")]
		public int[] GetTriangles()
		{
			return null;
		}

		[Address(RVA="0x1270AFC", Offset="0x1270AFC", VA="0x1270AFC")]
		public List<Vector4> GetUVs(int index)
		{
			return null;
		}

		[Address(RVA="0x1270DC0", Offset="0x1270DC0", VA="0x1270DC0")]
		public void RecalculateNormals()
		{
		}

		[Address(RVA="0x1270D30", Offset="0x1270D30", VA="0x1270D30")]
		public void SetTriangles(int[] triangles, int index)
		{
		}

		[Address(RVA="0x1270B48", Offset="0x1270B48", VA="0x1270B48")]
		public void SetUVs(int index, List<Vector4> uvs)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E588", Offset="0x104E588")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static z_Mesh.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<int[], IEnumerable<int>> <>9__22_0;

			[Address(RVA="0x127174C", Offset="0x127174C", VA="0x127174C")]
			static <>c()
			{
			}

			[Address(RVA="0x12717B0", Offset="0x12717B0", VA="0x12717B0")]
			public <>c()
			{
			}

			[Address(RVA="0x12717B8", Offset="0x12717B8", VA="0x12717B8")]
			internal IEnumerable<int> <GetTriangles>b__22_0(int[] x)
			{
				return null;
			}
		}
	}
}