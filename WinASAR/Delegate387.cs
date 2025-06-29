using System;

// Token: 0x02000393 RID: 915
internal sealed class Delegate387 : MulticastDelegate
{
	// Token: 0x06001DE0 RID: 7648
	public extern double Invoke(long long_0);

	// Token: 0x06001DE1 RID: 7649 RVA: 0x0000A7BB File Offset: 0x000089BB
	public static double smethod_0(long long_0, Delegate387 delegate387_0)
	{
		return delegate387_0(long_0);
	}

	// Token: 0x06001DE2 RID: 7650
	public extern Delegate387(object object_0, IntPtr intptr_0);

	// Token: 0x06001DE3 RID: 7651 RVA: 0x0000A7C6 File Offset: 0x000089C6
	static Delegate387()
	{
		Class15.smethod_14(typeof(Delegate387).TypeHandle);
	}

	// Token: 0x04000B63 RID: 2915
	internal static Delegate387 UepVnacxZP;
}
