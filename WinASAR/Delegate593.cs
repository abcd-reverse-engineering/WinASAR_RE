using System;

// Token: 0x02000461 RID: 1121
internal sealed class Delegate593 : MulticastDelegate
{
	// Token: 0x06002118 RID: 8472
	public extern string Invoke(object object_0);

	// Token: 0x06002119 RID: 8473 RVA: 0x0000BC75 File Offset: 0x00009E75
	public static string smethod_0(object object_0, Delegate593 delegate593_1)
	{
		return delegate593_1(object_0);
	}

	// Token: 0x0600211A RID: 8474
	public extern Delegate593(object object_0, IntPtr intptr_0);

	// Token: 0x0600211B RID: 8475 RVA: 0x0000BC80 File Offset: 0x00009E80
	static Delegate593()
	{
		Class15.smethod_14(typeof(Delegate593).TypeHandle);
	}

	// Token: 0x04000C31 RID: 3121
	internal static Delegate593 delegate593_0;
}
