using System;

// Token: 0x020003E1 RID: 993
internal sealed class Delegate465 : MulticastDelegate
{
	// Token: 0x06001F18 RID: 7960
	public extern bool Invoke(decimal decimal_0, decimal decimal_1);

	// Token: 0x06001F19 RID: 7961 RVA: 0x0000AF9D File Offset: 0x0000919D
	public static bool smethod_0(decimal decimal_0, decimal decimal_1, Delegate465 delegate465_1)
	{
		return delegate465_1(decimal_0, decimal_1);
	}

	// Token: 0x06001F1A RID: 7962
	public extern Delegate465(object object_0, IntPtr intptr_0);

	// Token: 0x06001F1B RID: 7963 RVA: 0x0000AFAA File Offset: 0x000091AA
	static Delegate465()
	{
		Class15.smethod_14(typeof(Delegate465).TypeHandle);
	}

	// Token: 0x04000BB1 RID: 2993
	internal static Delegate465 delegate465_0;
}
