using System;
using System.Collections;

// Token: 0x0200040A RID: 1034
internal sealed class Delegate506 : MulticastDelegate
{
	// Token: 0x06001FBC RID: 8124
	public extern ICollection Invoke(object object_0);

	// Token: 0x06001FBD RID: 8125 RVA: 0x0000B3BB File Offset: 0x000095BB
	public static ICollection smethod_0(object object_0, Delegate506 delegate506_1)
	{
		return delegate506_1(object_0);
	}

	// Token: 0x06001FBE RID: 8126
	public extern Delegate506(object object_0, IntPtr intptr_0);

	// Token: 0x06001FBF RID: 8127 RVA: 0x0000B3C6 File Offset: 0x000095C6
	static Delegate506()
	{
		Class15.smethod_14(typeof(Delegate506).TypeHandle);
	}

	// Token: 0x04000BDA RID: 3034
	internal static Delegate506 delegate506_0;
}
