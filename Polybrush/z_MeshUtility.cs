using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Polybrush
{
	public static class z_MeshUtility
	{
		[FieldOffset(Offset="0x0")]
		private readonly static Color clear;

		[FieldOffset(Offset="0x10")]
		public static Dictionary<z_Mesh, List<List<int>>> commonVerticesCache;

		[FieldOffset(Offset="0x18")]
		private static Dictionary<z_Mesh, Dictionary<z_Edge, List<int>>> adjacentTrianglesCache;

		[FieldOffset(Offset="0x20")]
		private static Dictionary<z_Mesh, List<List<int>>> commonNormalsCache;

		[Address(RVA="0x1276E6C", Offset="0x1276E6C", VA="0x1276E6C")]
		static z_MeshUtility()
		{
		}

		[Address(RVA="0x1271918", Offset="0x1271918", VA="0x1271918")]
		public static void Copy(Mesh dest, Mesh src)
		{
		}

		[Address(RVA="0x1271F54", Offset="0x1271F54", VA="0x1271F54")]
		public static Mesh CreateOverlayMesh(z_Mesh src)
		{
			return null;
		}

		[Address(RVA="0x1272488", Offset="0x1272488", VA="0x1272488")]
		public static Mesh CreateVertexBillboardMesh(z_Mesh src, List<List<int>> common)
		{
			return null;
		}

		[Address(RVA="0x127188C", Offset="0x127188C", VA="0x127188C")]
		public static Mesh DeepCopy(Mesh src)
		{
			return null;
		}

		[Address(RVA="0x1274944", Offset="0x1274944", VA="0x1274944")]
		public static Dictionary<z_Edge, List<int>> GetAdjacentTriangles(z_Mesh m)
		{
			return null;
		}

		[Address(RVA="0x1274358", Offset="0x1274358", VA="0x1274358")]
		public static Dictionary<int, List<int>> GetAdjacentVertices(z_Mesh mesh)
		{
			return null;
		}

		[Address(RVA="0x1273484", Offset="0x1273484", VA="0x1273484")]
		public static List<List<int>> GetCommonVertices(z_Mesh mesh)
		{
			return null;
		}

		[Address(RVA="0x1273840", Offset="0x1273840", VA="0x1273840")]
		public static List<z_CommonEdge> GetEdges(z_Mesh m)
		{
			return null;
		}

		[Address(RVA="0x12738C0", Offset="0x12738C0", VA="0x12738C0")]
		public static List<z_CommonEdge> GetEdges(z_Mesh m, Dictionary<int, int> lookup)
		{
			return null;
		}

		[Address(RVA="0x1273D04", Offset="0x1273D04", VA="0x1273D04")]
		public static HashSet<z_CommonEdge> GetEdgesDistinct(z_Mesh mesh, out List<z_CommonEdge> duplicates)
		{
			duplicates = null;
			return null;
		}

		[Address(RVA="0x1273D94", Offset="0x1273D94", VA="0x1273D94")]
		private static HashSet<z_CommonEdge> GetEdgesDistinct(z_Mesh m, Dictionary<int, int> lookup, out List<z_CommonEdge> duplicates)
		{
			duplicates = null;
			return null;
		}

		[Address(RVA="0x12742AC", Offset="0x12742AC", VA="0x12742AC")]
		public static HashSet<int> GetNonManifoldIndices(z_Mesh mesh)
		{
			return null;
		}

		[Address(RVA="0x1272F7C", Offset="0x1272F7C", VA="0x1272F7C")]
		public static Dictionary<int, Vector3> GetSmoothNormalLookup(z_Mesh mesh)
		{
			return null;
		}

		[Address(RVA="0x1274F30", Offset="0x1274F30", VA="0x1274F30")]
		public static List<List<int>> GetSmoothSeamLookup(z_Mesh m)
		{
			return null;
		}

		[Address(RVA="0x12755BC", Offset="0x12755BC", VA="0x12755BC")]
		public static string Print(Mesh m, int maxAttributesToList = 8)
		{
			return null;
		}

		[Address(RVA="0x1275298", Offset="0x1275298", VA="0x1275298")]
		public static void RecalculateNormals(z_Mesh m)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E5C8", Offset="0x104E5C8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static z_MeshUtility.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<int, int> <>9__7_0;

			[FieldOffset(Offset="0x10")]
			public static Func<IGrouping<z_RndVec3, int>, List<int>> <>9__7_2;

			[FieldOffset(Offset="0x18")]
			public static Func<IGrouping<z_RndVec3, int>, bool> <>9__17_1;

			[FieldOffset(Offset="0x20")]
			public static Func<IGrouping<z_RndVec3, int>, List<int>> <>9__17_2;

			[Address(RVA="0x1276F70", Offset="0x1276F70", VA="0x1276F70")]
			static <>c()
			{
			}

			[Address(RVA="0x1276FD4", Offset="0x1276FD4", VA="0x1276FD4")]
			public <>c()
			{
			}

			[Address(RVA="0x1276FDC", Offset="0x1276FDC", VA="0x1276FDC")]
			internal int <GetCommonVertices>b__7_0(int x)
			{
				return new int();
			}

			[Address(RVA="0x1276FE4", Offset="0x1276FE4", VA="0x1276FE4")]
			internal List<int> <GetCommonVertices>b__7_2(IGrouping<z_RndVec3, int> y)
			{
				return null;
			}

			[Address(RVA="0x1277034", Offset="0x1277034", VA="0x1277034")]
			internal bool <GetSmoothSeamLookup>b__17_1(IGrouping<z_RndVec3, int> n)
			{
				return new bool();
			}

			[Address(RVA="0x1277090", Offset="0x1277090", VA="0x1277090")]
			internal List<int> <GetSmoothSeamLookup>b__17_2(IGrouping<z_RndVec3, int> t)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E5D8", Offset="0x104E5D8")]
		private sealed class <>c__DisplayClass17_0
		{
			[FieldOffset(Offset="0x10")]
			public Vector3[] normals;

			[FieldOffset(Offset="0x18")]
			public Func<int, z_RndVec3> <>9__3;

			[Address(RVA="0x1275290", Offset="0x1275290", VA="0x1275290")]
			public <>c__DisplayClass17_0()
			{
			}

			[Address(RVA="0x12770E0", Offset="0x12770E0", VA="0x12770E0")]
			internal IEnumerable<IGrouping<z_RndVec3, int>> <GetSmoothSeamLookup>b__0(List<int> x)
			{
				return null;
			}

			[Address(RVA="0x1277180", Offset="0x1277180", VA="0x1277180")]
			internal z_RndVec3 <GetSmoothSeamLookup>b__3(int i)
			{
				return new z_RndVec3();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E5B8", Offset="0x104E5B8")]
		private sealed class <>c__DisplayClass7_0
		{
			[FieldOffset(Offset="0x10")]
			public Vector3[] v;

			[Address(RVA="0x1273838", Offset="0x1273838", VA="0x1273838")]
			public <>c__DisplayClass7_0()
			{
			}

			[Address(RVA="0x12771E0", Offset="0x12771E0", VA="0x12771E0")]
			internal z_RndVec3 <GetCommonVertices>b__1(int x)
			{
				return new z_RndVec3();
			}
		}
	}
}