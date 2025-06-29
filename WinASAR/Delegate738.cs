using System;

// Token: 0x020004F2 RID: 1266
internal sealed class Delegate738 : MulticastDelegate
{
	// Token: 0x0600235C RID: 9052
	public extern int Invoke(object object_0);

	// Token: 0x0600235D RID: 9053 RVA: 0x0000CAC0 File Offset: 0x0000ACC0
	public static int smethod_0(object object_0, Delegate738 delegate738_1)
	{
		return delegate738_1(object_0);
	}

	// Token: 0x0600235E RID: 9054
	public extern Delegate738(object object_0, IntPtr intptr_0);

	// Token: 0x0600235F RID: 9055 RVA: 0x0000CACB File Offset: 0x0000ACCB
	static Delegate738()
	{
		Class15.smethod_14(typeof(Delegate738).TypeHandle);
	}

	// Token: 0x04000CC2 RID: 3266
	internal static Delegate738 delegate738_0;
}
