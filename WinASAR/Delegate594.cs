using System;

// Token: 0x02000462 RID: 1122
internal sealed class Delegate594 : MulticastDelegate
{
	// Token: 0x0600211C RID: 8476
	public extern bool Invoke(object object_0);

	// Token: 0x0600211D RID: 8477 RVA: 0x0000BC8D File Offset: 0x00009E8D
	public static bool smethod_0(object object_0, Delegate594 delegate594_1)
	{
		return delegate594_1(object_0);
	}

	// Token: 0x0600211E RID: 8478
	public extern Delegate594(object object_0, IntPtr intptr_0);

	// Token: 0x0600211F RID: 8479 RVA: 0x0000BC98 File Offset: 0x00009E98
	static Delegate594()
	{
		Class15.smethod_14(typeof(Delegate594).TypeHandle);
	}

	// Token: 0x04000C32 RID: 3122
	internal static Delegate594 delegate594_0;
}
