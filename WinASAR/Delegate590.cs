using System;

// Token: 0x0200045E RID: 1118
internal sealed class Delegate590 : MulticastDelegate
{
	// Token: 0x0600210C RID: 8460
	public extern bool Invoke(object object_0);

	// Token: 0x0600210D RID: 8461 RVA: 0x0000BC27 File Offset: 0x00009E27
	public static bool smethod_0(object object_0, Delegate590 delegate590_1)
	{
		return delegate590_1(object_0);
	}

	// Token: 0x0600210E RID: 8462
	public extern Delegate590(object object_0, IntPtr intptr_0);

	// Token: 0x0600210F RID: 8463 RVA: 0x0000BC32 File Offset: 0x00009E32
	static Delegate590()
	{
		Class15.smethod_14(typeof(Delegate590).TypeHandle);
	}

	// Token: 0x04000C2E RID: 3118
	internal static Delegate590 delegate590_0;
}
