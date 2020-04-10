using System;

public interface IAssetDependentLifecycleObject
{
	void Initialize(Action finished);

	void LoadAssets(Action finished);

	void ReleaseAssets();

	void Shutdown();
}