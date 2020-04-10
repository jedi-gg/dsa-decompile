namespace Zenject
{
	public interface IFactory<out TValue> : IFactory
	{
		TValue Create();
	}
}