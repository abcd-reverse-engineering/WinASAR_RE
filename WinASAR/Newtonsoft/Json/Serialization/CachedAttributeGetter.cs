using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000E2 RID: 226
	internal static class CachedAttributeGetter<T> where T : Attribute
	{
		// Token: 0x060008D5 RID: 2261 RVA: 0x0000480B File Offset: 0x00002A0B
		[NullableContext(1)]
		[return: Nullable(2)]
		public static T GetAttribute(object type)
		{
			return CachedAttributeGetter<T>.threadSafeStore_0.Get(type);
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x000529D4 File Offset: 0x00050BD4
		static CachedAttributeGetter()
		{
			for (;;)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
				{
					goto IL_0003;
				}
				IL_0015:
				switch (num)
				{
				case 1:
					IL_0003:
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
					{
						goto IL_0015;
					}
					break;
				case 2:
					continue;
				case 3:
					return;
				}
				break;
			}
			CachedAttributeGetter<T>.threadSafeStore_0 = new ThreadSafeStore<object, T>(new Func<object, T>(JsonTypeReflector.GetAttribute<T>));
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00004818 File Offset: 0x00002A18
		internal static bool smethod_0()
		{
			return CachedAttributeGetter<T>.object_0 == null;
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00004822 File Offset: 0x00002A22
		internal static object smethod_1()
		{
			return CachedAttributeGetter<T>.object_0;
		}

		// Token: 0x040004AC RID: 1196
		[Nullable(new byte[] { 1, 1, 2 })]
		private static readonly ThreadSafeStore<object, T> threadSafeStore_0;

		// Token: 0x040004AD RID: 1197
		private static object object_0;
	}
}
