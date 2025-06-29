using System;

// Token: 0x02000439 RID: 1081
internal sealed class Delegate553 : MulticastDelegate
{
	// Token: 0x06002078 RID: 8312
	public extern Type Invoke(object object_0);

	// Token: 0x06002079 RID: 8313 RVA: 0x0000B871 File Offset: 0x00009A71
	public static Type smethod_0(object object_0, Delegate553 delegate553_1)
	{
		return delegate553_1(object_0);
	}

	// Token: 0x0600207A RID: 8314
	public extern Delegate553(object object_0, IntPtr intptr_0);

	// Token: 0x0600207B RID: 8315 RVA: 0x0000B87C File Offset: 0x00009A7C
	static Delegate553()
	{
		Class15.smethod_14(typeof(Delegate553).TypeHandle);
	}

	// Token: 0x04000C09 RID: 3081
	internal static Delegate553 delegate553_0;
}
