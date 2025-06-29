using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000F4 RID: 244
	public class DiagnosticsTraceWriter : ITraceWriter
	{
		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x00004A08 File Offset: 0x00002C08
		// (set) Token: 0x06000980 RID: 2432 RVA: 0x00057B58 File Offset: 0x00055D58
		public TraceLevel LevelFilter
		{
			[CompilerGenerated]
			get
			{
				return this.traceLevel_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.traceLevel_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
						break;
					}
					break;
				}
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00057B90 File Offset: 0x00055D90
		private TraceEventType method_0(TraceLevel traceLevel_1)
		{
			for (;;)
			{
				switch (traceLevel_1)
				{
				case TraceLevel.Error:
					return TraceEventType.Error;
				case TraceLevel.Warning:
					return TraceEventType.Warning;
				case TraceLevel.Info:
					return TraceEventType.Information;
				case TraceLevel.Verbose:
					return TraceEventType.Verbose;
				default:
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						case 2:
							return TraceEventType.Error;
						}
						goto Block_2;
					}
					goto IL_0043;
				}
				}
			}
			Block_2:
			IL_0043:
			throw new ArgumentOutOfRangeException(Class15.smethod_17(926357857 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296));
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00057C04 File Offset: 0x00055E04
		[NullableContext(1)]
		public void Trace(TraceLevel level, string message, [Nullable(2)] Exception ex)
		{
			IL_0069:
			while (level != TraceLevel.Off)
			{
				TraceEventCache traceEventCache = new TraceEventCache();
				int num = 1;
				TraceEventType traceEventType;
				IEnumerator enumerator;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
				{
					do
					{
						switch (num)
						{
						case 1:
							traceEventType = this.method_0(level);
							goto IL_001E;
						case 2:
							goto IL_001E;
						case 3:
							return;
						case 4:
							goto IL_0069;
						case 5:
							return;
						}
						break;
						IL_001E:
						enumerator = global::System.Diagnostics.Trace.Listeners.GetEnumerator();
						num = 0;
					}
					while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0);
				}
				try
				{
					IL_01C4:
					while (enumerator.MoveNext())
					{
						TraceListener traceListener;
						for (;;)
						{
							IL_00D9:
							traceListener = (TraceListener)enumerator.Current;
							IL_00CD:
							while (!traceListener.IsThreadSafe)
							{
								for (;;)
								{
									TraceListener traceListener2 = traceListener;
									int num2 = 1;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
									{
										switch (num2)
										{
										case 1:
											goto IL_0111;
										case 2:
											goto IL_00D9;
										case 3:
										case 6:
											goto IL_00E9;
										case 4:
											goto IL_00CD;
										case 5:
										case 7:
											goto IL_01C4;
										case 8:
											continue;
										case 9:
											goto IL_01B6;
										case 10:
											goto IL_0114;
										case 11:
											goto IL_01D0;
										}
										goto Block_8;
									}
									goto IL_0110;
								}
							}
							goto Block_9;
						}
						IL_01B6:
						if (global::System.Diagnostics.Trace.AutoFlush)
						{
							goto IL_01BD;
						}
						continue;
						IL_00E9:
						traceListener.TraceEvent(traceEventCache, Class15.smethod_17(89055676 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454), traceEventType, 0, message);
						goto IL_01B6;
						Block_9:
						goto IL_00E9;
						IL_01BD:
						traceListener.Flush();
						continue;
						Block_8:
						goto IL_01BD;
						IL_0114:
						bool flag;
						try
						{
							TraceListener traceListener2;
							Monitor.Enter(traceListener2, ref flag);
							int num3 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
							{
								goto IL_0163;
							}
							IL_0130:
							traceListener.TraceEvent(traceEventCache, Class15.smethod_17(432130227 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2), traceEventType, 0, message);
							num3 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
							{
								goto IL_0174;
							}
							IL_0163:
							switch (num3)
							{
							case 1:
								goto IL_0130;
							}
							IL_0174:;
						}
						finally
						{
							if (flag)
							{
								int num4 = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
								{
									goto IL_01A4;
								}
								IL_018C:
								TraceListener traceListener2;
								Monitor.Exit(traceListener2);
								num4 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
								{
									goto IL_01B5;
								}
								IL_01A4:
								switch (num4)
								{
								case 1:
									goto IL_018C;
								}
							}
							IL_01B5:;
						}
						goto IL_01B6;
						IL_0111:
						flag = false;
						goto IL_0114;
						IL_0110:
						goto IL_0111;
					}
					IL_01D0:
					return;
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					while (disposable != null)
					{
						int num5 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
						{
							goto IL_01EF;
						}
						IL_0207:
						switch (num5)
						{
						case 0:
							goto IL_0223;
						case 1:
							IL_01EF:
							disposable.Dispose();
							num5 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
							{
								goto IL_0207;
							}
							goto IL_0223;
						case 2:
							break;
						default:
							goto IL_0223;
						}
					}
					IL_0223:;
				}
				return;
			}
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00057E6C File Offset: 0x0005606C
		public DiagnosticsTraceWriter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x040004E9 RID: 1257
		[CompilerGenerated]
		private TraceLevel traceLevel_0;
	}
}
