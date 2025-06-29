using System;

// Token: 0x020003A5 RID: 933
internal sealed class Delegate405 : MulticastDelegate
{
	// Token: 0x06001E28 RID: 7720
	public extern double Invoke(double double_0);

	// Token: 0x06001E29 RID: 7721 RVA: 0x0000A989 File Offset: 0x00008B89
	public static double smethod_0(double double_0, Delegate405 delegate405_1)
	{
		return delegate405_1(double_0);
	}

	// Token: 0x06001E2A RID: 7722
	public extern Delegate405(object object_0, IntPtr intptr_0);

	// Token: 0x06001E2B RID: 7723 RVA: 0x0000A994 File Offset: 0x00008B94
	static Delegate405()
	{
		Class15.smethod_14(typeof(Delegate405).TypeHandle);
	}

	// Token: 0x04000B75 RID: 2933
	internal static Delegate405 delegate405_0;
}
