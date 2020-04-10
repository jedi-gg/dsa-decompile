using System;

public interface IMonoArchetypePooledItem
{
	void Initialize();

	void Reinitialize();

	void Shutdown();
}