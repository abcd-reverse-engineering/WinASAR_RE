using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000DF RID: 223
	[NullableContext(1)]
	[Nullable(0)]
	internal class ThreadSafeStore<TKey, [Nullable(2)] TValue>
	{
		// Token: 0x060008B9 RID: 2233 RVA: 0x00004748 File Offset: 0x00002948
		public ThreadSafeStore(Func<TKey, TValue> creator)
		{
			ValidationUtils.ArgumentNotNull(creator, Class15.smethod_17(1116157607 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54));
			this.func_0 = creator;
			this.concurrentDictionary_0 = new ConcurrentDictionary<TKey, TValue>();
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x0000477F File Offset: 0x0000297F
		public TValue Get(TKey key)
		{
			return this.concurrentDictionary_0.GetOrAdd(key, this.func_0);
		}

		// Token: 0x040004A8 RID: 1192
		private readonly ConcurrentDictionary<TKey, TValue> concurrentDictionary_0;

		// Token: 0x040004A9 RID: 1193
		private readonly Func<TKey, TValue> func_0;
	}
}
