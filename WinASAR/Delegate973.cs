using System;

// Token: 0x020005DD RID: 1501
internal sealed class Delegate973 : MulticastDelegate
{
	// Token: 0x06002708 RID: 9992
	public extern double Invoke(object object_0);

	// Token: 0x06002709 RID: 9993 RVA: 0x0000E202 File Offset: 0x0000C402
	public static double smethod_0(object object_0, Delegate973 delegate973_1)
	{
		return delegate973_1(object_0);
	}

	// Token: 0x0600270A RID: 9994
	public extern Delegate973(object object_0, IntPtr intptr_0);

	// Token: 0x0600270B RID: 9995 RVA: 0x0000E20D File Offset: 0x0000C40D
	static Delegate973()
	{
		Class15.smethod_14(typeof(Delegate973).TypeHandle);
	}

	// Token: 0x04000DAD RID: 3501
	internal static Delegate973 delegate973_0;
}
