using System;

// Token: 0x02000387 RID: 903
internal sealed class Delegate375 : MulticastDelegate
{
	// Token: 0x06001DB0 RID: 7600
	public extern int Invoke(int int_0, int int_1);

	// Token: 0x06001DB1 RID: 7601 RVA: 0x0000A68D File Offset: 0x0000888D
	public static int smethod_0(int int_0, int int_1, Delegate375 delegate375_1)
	{
		return delegate375_1(int_0, int_1);
	}

	// Token: 0x06001DB2 RID: 7602
	public extern Delegate375(object object_0, IntPtr intptr_0);

	// Token: 0x06001DB3 RID: 7603 RVA: 0x0000A69A File Offset: 0x0000889A
	static Delegate375()
	{
		Class15.smethod_14(typeof(Delegate375).TypeHandle);
	}

	// Token: 0x04000B57 RID: 2903
	internal static Delegate375 delegate375_0;
}
