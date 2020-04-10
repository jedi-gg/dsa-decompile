namespace Zenject
{
	public interface IFactory<out TValue, in TParam1> : IFactory
	{
		TValue Create(TParam1 param);
	}
}