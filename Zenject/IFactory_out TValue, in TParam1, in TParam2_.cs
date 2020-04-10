namespace Zenject
{
	public interface IFactory<out TValue, in TParam1, in TParam2> : IFactory
	{
		TValue Create(TParam1 param1, TParam2 param2);
	}
}