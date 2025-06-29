using System;

// Token: 0x02000448 RID: 1096
internal sealed class Delegate568 : MulticastDelegate
{
	// Token: 0x060020B4 RID: 8372
	public extern bool Invoke(object object_0);

	// Token: 0x060020B5 RID: 8373 RVA: 0x0000B9EF File Offset: 0x00009BEF
	public static bool smethod_0(object object_0, Delegate568 delegate568_1)
	{
		return delegate568_1(object_0);
	}

	// Token: 0x060020B6 RID: 8374
	public extern Delegate568(object object_0, IntPtr intptr_0);

	// Token: 0x060020B7 RID: 8375 RVA: 0x0000B9FA File Offset: 0x00009BFA
	static Delegate568()
	{
		Class15.smethod_14(typeof(Delegate568).TypeHandle);
	}

	// Token: 0x04000C18 RID: 3096
	internal static Delegate568 delegate568_0;
}
