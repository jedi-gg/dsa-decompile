namespace Zenject
{
	public interface IFactory<out TValue, in TParam1, in TParam2, in TParam3, in TParam4> : IFactory
	{
		TValue Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);
	}
}