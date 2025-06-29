using System;

// Token: 0x0200058E RID: 1422
internal sealed class Delegate894 : MulticastDelegate
{
	// Token: 0x060025CC RID: 9676
	public extern string Invoke(object object_0);

	// Token: 0x060025CD RID: 9677 RVA: 0x0000DA38 File Offset: 0x0000BC38
	public static string smethod_0(object object_0, Delegate894 delegate894_1)
	{
		return delegate894_1(object_0);
	}

	// Token: 0x060025CE RID: 9678
	public extern Delegate894(object object_0, IntPtr intptr_0);

	// Token: 0x060025CF RID: 9679 RVA: 0x0000DA43 File Offset: 0x0000BC43
	static Delegate894()
	{
		Class15.smethod_14(typeof(Delegate894).TypeHandle);
	}

	// Token: 0x04000D5E RID: 3422
	internal static Delegate894 delegate894_0;
}
