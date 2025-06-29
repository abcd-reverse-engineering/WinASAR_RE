using System;

// Token: 0x02000533 RID: 1331
internal sealed class Delegate803 : MulticastDelegate
{
	// Token: 0x06002460 RID: 9312
	public extern int Invoke(ref long long_0, long long_1);

	// Token: 0x06002461 RID: 9313 RVA: 0x0000D128 File Offset: 0x0000B328
	public static int smethod_0(ref long long_0, long long_1, Delegate803 delegate803_1)
	{
		return delegate803_1(ref long_0, long_1);
	}

	// Token: 0x06002462 RID: 9314
	public extern Delegate803(object object_0, IntPtr intptr_0);

	// Token: 0x06002463 RID: 9315 RVA: 0x0000D135 File Offset: 0x0000B335
	static Delegate803()
	{
		Class15.smethod_14(typeof(Delegate803).TypeHandle);
	}

	// Token: 0x04000D03 RID: 3331
	internal static Delegate803 delegate803_0;
}
