using System;

// Token: 0x02000573 RID: 1395
internal sealed class Delegate867 : MulticastDelegate
{
	// Token: 0x06002560 RID: 9568
	public extern bool Invoke(object object_0);

	// Token: 0x06002561 RID: 9569 RVA: 0x0000D7A8 File Offset: 0x0000B9A8
	public static bool smethod_0(object object_0, Delegate867 delegate867_1)
	{
		return delegate867_1(object_0);
	}

	// Token: 0x06002562 RID: 9570
	public extern Delegate867(object object_0, IntPtr intptr_0);

	// Token: 0x06002563 RID: 9571 RVA: 0x0000D7B3 File Offset: 0x0000B9B3
	static Delegate867()
	{
		Class15.smethod_14(typeof(Delegate867).TypeHandle);
	}

	// Token: 0x04000D43 RID: 3395
	internal static Delegate867 delegate867_0;
}
