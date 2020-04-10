using System;
using System.Collections.Generic;

public interface IEventModel
{
	string BannerImage
	{
		get;
	}

	string BannerText
	{
		get;
	}

	ulong BeginTimestamp
	{
		get;
	}

	ulong ContentId
	{
		get;
	}

	string Description
	{
		get;
	}

	ulong EndTimestamp
	{
		get;
	}

	ulong EventGroupId
	{
		get;
	}

	string Image
	{
		get;
	}

	string Name
	{
		get;
	}

	string PreviewText
	{
		get;
	}

	IList<ulong> ShowcaseItems
	{
		get;
	}

	long SortOrder
	{
		get;
	}

	bool HasBegun();

	bool HasEnded(ulong bufferWindowS = 0L);

	bool IsActive();
}