using System;

public interface IItemFindListView
{
	long? GetItemGoalCount();

	void RebindItemFindList();

	void SetItemFindResults(ulong itemId, int itemFindEntryCount);

	void SetListItemBindDataDelegate(WrappedScrollRect.BindDataDelegate bindDataDelegate);

	void SetTutorialPointAtLookup(ItemFindListIndexTutorialPointAtLookup lookup);
}