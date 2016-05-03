using System;

namespace Panframe
{
	public enum PFAssetMessage : uint
	{
		Loaded = 1,
		Playing = 2,
		Paused = 3,
		Stopped = 4,
		Complete = 5,
		Downloading = 6,
		Downloaded = 7,
		Downloadcancelled = 8,
		Error = 9,
		Seeking = 10,
		BufferEmpty = 11,
		BufferFull = 12,
		BufferKeepingUp = 13
	}

	public enum PFNavigationMode : uint
	{
		Motion = 0,
		Touch = 1
	}

	public enum PFBlindspotLocation : uint
	{
		None = 0,
		Bottom = 1,
		Top = 2
	}
}