using System;
using System.Collections;

// Token: 0x02000407 RID: 1031
internal sealed class Delegate503 : MulticastDelegate
{
	// Token: 0x06001FB0 RID: 8112
	public extern ICollection Invoke(object object_0);

	// Token: 0x06001FB1 RID: 8113 RVA: 0x0000B36F File Offset: 0x0000956F
	public static ICollection smethod_0(object object_0, Delegate503 delegate503_0)
	{
		return delegate503_0(object_0);
	}

	// Token: 0x06001FB2 RID: 8114
	public extern Delegate503(object object_0, IntPtr intptr_0);

	// Token: 0x06001FB3 RID: 8115 RVA: 0x0000B37A File Offset: 0x0000957A
	static Delegate503()
	{
		Class15.smethod_14(typeof(Delegate503).TypeHandle);
	}

	// Token: 0x04000BD7 RID: 3031
	internal static Delegate503 wrImdigUym;
}
