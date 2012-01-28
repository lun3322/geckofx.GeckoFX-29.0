using System;

namespace Gecko.Cache
{
	public sealed class CacheSession
	{
		private nsICacheSession _cacheSession;

		internal CacheSession(nsICacheSession cacheSession)
		{
			_cacheSession = cacheSession;
		}

		public bool DoomEntriesIfExpired
		{
			get { return _cacheSession.GetDoomEntriesIfExpiredAttribute(); }
			set { _cacheSession.SetDoomEntriesIfExpiredAttribute(value); }
		}

		public bool IsStorageEnabled
		{

			get { return _cacheSession.IsStorageEnabled(); }
		}


		public void EvictEntries()
		{
			_cacheSession.EvictEntries();
		}

		public CacheEntryDescriptor OpenCacheEntry(string key, CacheAccessMode accessRequested, bool blockingMode)
		{
			nsICacheEntryDescriptor descriptor = null;
			try
			{
				descriptor = _cacheSession.OpenCacheEntry( new nsACString( key ), ( IntPtr ) ( int ) accessRequested, blockingMode );
			}
			catch ( System.Runtime.InteropServices.COMException comException )
			{
				
			}
			catch ( Exception )
			{
				
			}
			return descriptor != null ? new CacheEntryDescriptor( descriptor ) : null;
		}

	}

	public enum CacheAccessMode
	{
		None=0,
		Read=1,
		Write=2,
		ReadWrite=3
	}
}