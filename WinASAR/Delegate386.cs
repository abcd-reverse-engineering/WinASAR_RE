using System;

// Token: 0x02000392 RID: 914
internal sealed class Delegate386 : MulticastDelegate
{
	// Token: 0x06001DDC RID: 7644
	public extern decimal Invoke(long long_0);

	// Token: 0x06001DDD RID: 7645 RVA: 0x0000A7A3 File Offset: 0x000089A3
	public static decimal smethod_0(long long_0, Delegate386 delegate386_1)
	{
		return delegate386_1(long_0);
	}

	// Token: 0x06001DDE RID: 7646
	public extern Delegate386(object object_0, IntPtr intptr_0);

	// Token: 0x06001DDF RID: 7647 RVA: 0x0000A7AE File Offset: 0x000089AE
	static Delegate386()
	{
		Class15.smethod_14(typeof(Delegate386).TypeHandle);
	}

	// Token: 0x04000B62 RID: 2914
	internal static Delegate386 delegate386_0;
}
