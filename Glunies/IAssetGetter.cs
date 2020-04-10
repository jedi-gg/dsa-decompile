using System;

namespace Glunies
{
	public interface IAssetGetter
	{
		void GetAsset(string assetId, bool persistent, Action<AssetHandle> finished);
	}
}