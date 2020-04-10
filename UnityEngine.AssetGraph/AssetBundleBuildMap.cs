using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.AssetGraph
{
	public class AssetBundleBuildMap : ScriptableObject
	{
		[FieldOffset(Offset="0x18")]
		[SerializeField]
		private List<AssetBundleBuildMap.AssetBundleEntry> m_assetBundles;

		[FieldOffset(Offset="0x0")]
		private static AssetBundleBuildMap s_map;

		public List<AssetBundleBuildMap.AssetBundleEntry> AssetBundles
		{
			[Address(RVA="0x151A524", Offset="0x151A524", VA="0x151A524")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x151B284", Offset="0x151B284", VA="0x151B284")]
		public AssetBundleBuildMap()
		{
		}

		[Address(RVA="0x151AB00", Offset="0x151AB00", VA="0x151AB00")]
		public void Clear()
		{
		}

		[Address(RVA="0x151AB60", Offset="0x151AB60", VA="0x151AB60")]
		public void ClearFromId(string id)
		{
		}

		[Address(RVA="0x151A710", Offset="0x151A710", VA="0x151A710")]
		internal static string[] FullNameToNameAndVariant(string assetBundleFullName)
		{
			return null;
		}

		[Address(RVA="0x151B184", Offset="0x151B184", VA="0x151B184")]
		public string[] GetAllAssetBundleNames()
		{
			return null;
		}

		[Address(RVA="0x151A96C", Offset="0x151A96C", VA="0x151A96C")]
		public AssetBundleBuildMap.AssetBundleEntry GetAssetBundle(string registererId, string assetBundleFullName)
		{
			return null;
		}

		[Address(RVA="0x151B08C", Offset="0x151B08C", VA="0x151B08C")]
		public string GetAssetBundleName(string assetPath)
		{
			return null;
		}

		[Address(RVA="0x151AC38", Offset="0x151AC38", VA="0x151AC38")]
		public AssetBundleBuildMap.AssetBundleEntry GetAssetBundleWithNameAndVariant(string registererId, string assetBundleName, string variantName)
		{
			return null;
		}

		[Address(RVA="0x151AE0C", Offset="0x151AE0C", VA="0x151AE0C")]
		public string[] GetAssetPathsFromAssetBundle(string assetBundleName)
		{
			return null;
		}

		[Address(RVA="0x151AC70", Offset="0x151AC70", VA="0x151AC70")]
		public string[] GetAssetPathsFromAssetBundleAndAssetName(string assetbundleName, string assetName)
		{
			return null;
		}

		[Address(RVA="0x151A52C", Offset="0x151A52C", VA="0x151A52C")]
		public static AssetBundleBuildMap GetBuildMap()
		{
			return null;
		}

		[Address(RVA="0x151B180", Offset="0x151B180", VA="0x151B180")]
		public string GetImplicitAssetBundleName(string assetPath)
		{
			return null;
		}

		[Address(RVA="0x151A620", Offset="0x151A620", VA="0x151A620")]
		private static bool Load()
		{
			return new bool();
		}

		[Address(RVA="0x151A62C", Offset="0x151A62C", VA="0x151A62C")]
		internal static string MakeFullName(string assetBundleName, string variantName)
		{
			return null;
		}

		[Address(RVA="0x151A628", Offset="0x151A628", VA="0x151A628")]
		public static void SetMapDirty()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E358", Offset="0x104E358")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static AssetBundleBuildMap.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<AssetBundleBuildMap.AssetBundleEntry, IEnumerable<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>> <>9__15_1;

			[FieldOffset(Offset="0x10")]
			public static Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, string> <>9__15_2;

			[FieldOffset(Offset="0x18")]
			public static Func<AssetBundleBuildMap.AssetBundleEntry, string> <>9__18_0;

			[Address(RVA="0x151B28C", Offset="0x151B28C", VA="0x151B28C")]
			static <>c()
			{
			}

			[Address(RVA="0x151B2F0", Offset="0x151B2F0", VA="0x151B2F0")]
			public <>c()
			{
			}

			[Address(RVA="0x151B32C", Offset="0x151B32C", VA="0x151B32C")]
			internal string <GetAllAssetBundleNames>b__18_0(AssetBundleBuildMap.AssetBundleEntry e)
			{
				return null;
			}

			[Address(RVA="0x151B2F8", Offset="0x151B2F8", VA="0x151B2F8")]
			internal IEnumerable<AssetBundleBuildMap.AssetBundleEntry.AssetPathString> <GetAssetPathsFromAssetBundle>b__15_1(AssetBundleBuildMap.AssetBundleEntry e)
			{
				return null;
			}

			[Address(RVA="0x151B324", Offset="0x151B324", VA="0x151B324")]
			internal string <GetAssetPathsFromAssetBundle>b__15_2(AssetBundleBuildMap.AssetBundleEntry.AssetPathString s)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E318", Offset="0x104E318")]
		private sealed class <>c__DisplayClass10_0
		{
			[FieldOffset(Offset="0x10")]
			public string assetBundleFullName;

			[Address(RVA="0x151AAF8", Offset="0x151AAF8", VA="0x151AAF8")]
			public <>c__DisplayClass10_0()
			{
			}

			[Address(RVA="0x151B358", Offset="0x151B358", VA="0x151B358")]
			internal bool <GetAssetBundle>b__0(AssetBundleBuildMap.AssetBundleEntry v)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E328", Offset="0x104E328")]
		private sealed class <>c__DisplayClass12_0
		{
			[FieldOffset(Offset="0x10")]
			public string id;

			[Address(RVA="0x151AC30", Offset="0x151AC30", VA="0x151AC30")]
			public <>c__DisplayClass12_0()
			{
			}

			[Address(RVA="0x151B390", Offset="0x151B390", VA="0x151B390")]
			internal bool <ClearFromId>b__0(AssetBundleBuildMap.AssetBundleEntry e)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E338", Offset="0x104E338")]
		private sealed class <>c__DisplayClass14_0
		{
			[FieldOffset(Offset="0x10")]
			public string assetbundleName;

			[FieldOffset(Offset="0x18")]
			public string assetName;

			[Address(RVA="0x151AE04", Offset="0x151AE04", VA="0x151AE04")]
			public <>c__DisplayClass14_0()
			{
			}

			[Address(RVA="0x151B3C8", Offset="0x151B3C8", VA="0x151B3C8")]
			internal bool <GetAssetPathsFromAssetBundleAndAssetName>b__0(AssetBundleBuildMap.AssetBundleEntry ab)
			{
				return new bool();
			}

			[Address(RVA="0x151B400", Offset="0x151B400", VA="0x151B400")]
			internal IEnumerable<string> <GetAssetPathsFromAssetBundleAndAssetName>b__1(AssetBundleBuildMap.AssetBundleEntry ab)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E348", Offset="0x104E348")]
		private sealed class <>c__DisplayClass15_0
		{
			[FieldOffset(Offset="0x10")]
			public string assetBundleName;

			[Address(RVA="0x15A1C80", Offset="0x15A1C80", VA="0x15A1C80")]
			public <>c__DisplayClass15_0()
			{
			}

			[Address(RVA="0x15A1C88", Offset="0x15A1C88", VA="0x15A1C88")]
			internal bool <GetAssetPathsFromAssetBundle>b__0(AssetBundleBuildMap.AssetBundleEntry e)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E368", Offset="0x104E368")]
		private sealed class <>c__DisplayClass16_0
		{
			[FieldOffset(Offset="0x10")]
			public string assetPath;

			[Address(RVA="0x15A1CC0", Offset="0x15A1CC0", VA="0x15A1CC0")]
			public <>c__DisplayClass16_0()
			{
			}

			[Address(RVA="0x15A1CC8", Offset="0x15A1CC8", VA="0x15A1CC8")]
			internal bool <GetAssetBundleName>b__0(AssetBundleBuildMap.AssetBundleEntry e)
			{
				return new bool();
			}
		}

		[Serializable]
		public class AssetBundleEntry
		{
			[FieldOffset(Offset="0x10")]
			[SerializeField]
			internal string m_assetBundleName;

			[FieldOffset(Offset="0x18")]
			[SerializeField]
			internal string m_assetBundleVariantName;

			[FieldOffset(Offset="0x20")]
			[SerializeField]
			internal string m_fullName;

			[FieldOffset(Offset="0x28")]
			[SerializeField]
			internal List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString> m_assets;

			[FieldOffset(Offset="0x30")]
			[SerializeField]
			public string m_registererId;

			public string FullName
			{
				[Address(RVA="0x15A1DC8", Offset="0x15A1DC8", VA="0x15A1DC8")]
				get
				{
					return null;
				}
			}

			public string Name
			{
				[Address(RVA="0x15A1DB8", Offset="0x15A1DB8", VA="0x15A1DB8")]
				get
				{
					return null;
				}
			}

			public string Variant
			{
				[Address(RVA="0x15A1DC0", Offset="0x15A1DC0", VA="0x15A1DC0")]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x15A1DD0", Offset="0x15A1DD0", VA="0x15A1DD0")]
			public AssetBundleEntry(string registererId, string assetBundleName, string variantName)
			{
			}

			[Address(RVA="0x15A1F18", Offset="0x15A1F18", VA="0x15A1F18")]
			public void AddAssets(string id, IEnumerable<string> assets)
			{
			}

			[Address(RVA="0x15A1EB0", Offset="0x15A1EB0", VA="0x15A1EB0")]
			public void Clear()
			{
			}

			[Address(RVA="0x15A21D4", Offset="0x15A21D4", VA="0x15A21D4")]
			public IEnumerable<string> GetAssetFromAssetName(string assetName)
			{
				return null;
			}

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051598", Offset="0x1051598")]
			[Serializable]
			private sealed class <>c
			{
				[FieldOffset(Offset="0x0")]
				public readonly static AssetBundleBuildMap.AssetBundleEntry.<>c <>9;

				[FieldOffset(Offset="0x8")]
				public static Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, string> <>9__15_1;

				[Address(RVA="0x15A23A0", Offset="0x15A23A0", VA="0x15A23A0")]
				static <>c()
				{
				}

				[Address(RVA="0x15A2404", Offset="0x15A2404", VA="0x15A2404")]
				public <>c()
				{
				}

				[Address(RVA="0x15A240C", Offset="0x15A240C", VA="0x15A240C")]
				internal string <GetAssetFromAssetName>b__15_1(AssetBundleBuildMap.AssetBundleEntry.AssetPathString s)
				{
					return null;
				}
			}

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051588", Offset="0x1051588")]
			private sealed class <>c__DisplayClass15_0
			{
				[FieldOffset(Offset="0x10")]
				public string assetName;

				[Address(RVA="0x15A2398", Offset="0x15A2398", VA="0x15A2398")]
				public <>c__DisplayClass15_0()
				{
				}

				[Address(RVA="0x15A2414", Offset="0x15A2414", VA="0x15A2414")]
				internal bool <GetAssetFromAssetName>b__0(AssetBundleBuildMap.AssetBundleEntry.AssetPathString a)
				{
					return new bool();
				}
			}

			[Serializable]
			internal struct AssetPathString
			{
				[FieldOffset(Offset="0x0")]
				[SerializeField]
				public string original;

				[FieldOffset(Offset="0x8")]
				[SerializeField]
				public string lower;

				[Address(RVA="0xF05E58", Offset="0xF05E58", VA="0xF05E58")]
				internal AssetPathString(string s)
				{
				}
			}
		}
	}
}