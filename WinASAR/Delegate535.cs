using System;
using System.Linq.Expressions;

// Token: 0x02000427 RID: 1063
internal sealed class Delegate535 : MulticastDelegate
{
	// Token: 0x06002030 RID: 8240
	public extern Expression Invoke(object object_0);

	// Token: 0x06002031 RID: 8241 RVA: 0x0000B6AB File Offset: 0x000098AB
	public static Expression smethod_0(object object_0, Delegate535 delegate535_1)
	{
		return delegate535_1(object_0);
	}

	// Token: 0x06002032 RID: 8242
	public extern Delegate535(object object_0, IntPtr intptr_0);

	// Token: 0x06002033 RID: 8243 RVA: 0x0000B6B6 File Offset: 0x000098B6
	static Delegate535()
	{
		Class15.smethod_14(typeof(Delegate535).TypeHandle);
	}

	// Token: 0x04000BF7 RID: 3063
	internal static Delegate535 delegate535_0;
}
