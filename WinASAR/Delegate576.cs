using System;

// Token: 0x02000450 RID: 1104
internal sealed class Delegate576 : MulticastDelegate
{
	// Token: 0x060020D4 RID: 8404
	public extern string Invoke(object object_0);

	// Token: 0x060020D5 RID: 8405 RVA: 0x0000BAC1 File Offset: 0x00009CC1
	public static string smethod_0(object object_0, Delegate576 delegate576_1)
	{
		return delegate576_1(object_0);
	}

	// Token: 0x060020D6 RID: 8406
	public extern Delegate576(object object_0, IntPtr intptr_0);

	// Token: 0x060020D7 RID: 8407 RVA: 0x0000BACC File Offset: 0x00009CCC
	static Delegate576()
	{
		Class15.smethod_14(typeof(Delegate576).TypeHandle);
	}

	// Token: 0x04000C20 RID: 3104
	internal static Delegate576 delegate576_0;
}
