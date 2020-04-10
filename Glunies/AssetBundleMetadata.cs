using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

namespace Glunies
{
	public class AssetBundleMetadata
	{
		[FieldOffset(Offset="0x10")]
		private Serverproto.AssetBundleMetadata _metadata;

		[FieldOffset(Offset="0x18")]
		private Dictionary<string, BundleInfo> _bundleInfoLookup;

		public IReadOnlyList<BundleInfo> BundleInfos
		{
			[Address(RVA="0x14FADA4", Offset="0x14FADA4", VA="0x14FADA4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x14FADD4", Offset="0x14FADD4", VA="0x14FADD4")]
		public AssetBundleMetadata(Glunies.AssetBundleMetadata.Builder builder)
		{
		}

		[Address(RVA="0x14FAE1C", Offset="0x14FAE1C", VA="0x14FAE1C")]
		private void BuildLookup()
		{
		}

		[Address(RVA="0x14FB134", Offset="0x14FB134", VA="0x14FB134")]
		public uint GetCrc(string bundleName)
		{
			return new uint();
		}

		[Address(RVA="0x14FB1DC", Offset="0x14FB1DC", VA="0x14FB1DC")]
		public ulong GetDownloadSizeBytes(string bundleName)
		{
			return new ulong();
		}

		[Address(RVA="0x14FB154", Offset="0x14FB154", VA="0x14FB154")]
		private BundleInfo LookupBundleInfo(string bundleName)
		{
			return null;
		}

		[Address(RVA="0x14FB3CC", Offset="0x14FB3CC", VA="0x14FB3CC", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x14FB200", Offset="0x14FB200", VA="0x14FB200")]
		public void WriteTo(string filePath)
		{
		}

		public class Builder
		{
			[FieldOffset(Offset="0x10")]
			private Serverproto.AssetBundleMetadata _metadata;

			public Serverproto.AssetBundleMetadata Metadata
			{
				[Address(RVA="0x14FAE14", Offset="0x14FAE14", VA="0x14FAE14")]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x14FBB90", Offset="0x14FBB90", VA="0x14FBB90")]
			public Builder()
			{
			}

			[Address(RVA="0x14FB98C", Offset="0x14FB98C", VA="0x14FB98C")]
			public Glunies.AssetBundleMetadata.Builder AddBundleInfo(string bundleName, ulong downloadSizeByte, ulong crc, int? downloadOrder, bool isTutorialAsset)
			{
				return null;
			}

			[Address(RVA="0x14FBB30", Offset="0x14FBB30", VA="0x14FBB30")]
			public Glunies.AssetBundleMetadata Build()
			{
				return null;
			}

			[Address(RVA="0x14FB8FC", Offset="0x14FB8FC", VA="0x14FB8FC")]
			public Glunies.AssetBundleMetadata.Builder ParseProtobufMsg(byte[] data)
			{
				return null;
			}
		}
	}
}