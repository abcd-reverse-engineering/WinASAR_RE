using System;

// Token: 0x02000492 RID: 1170
internal sealed class Delegate642 : MulticastDelegate
{
	// Token: 0x060021DC RID: 8668
	public extern int Invoke(ref int int_0, int int_1);

	// Token: 0x060021DD RID: 8669 RVA: 0x0000C161 File Offset: 0x0000A361
	public static int smethod_0(ref int int_0, int int_1, Delegate642 delegate642_1)
	{
		return delegate642_1(ref int_0, int_1);
	}

	// Token: 0x060021DE RID: 8670
	public extern Delegate642(object object_0, IntPtr intptr_0);

	// Token: 0x060021DF RID: 8671 RVA: 0x0000C16E File Offset: 0x0000A36E
	static Delegate642()
	{
		Class15.smethod_14(typeof(Delegate642).TypeHandle);
	}

	// Token: 0x04000C62 RID: 3170
	internal static Delegate642 delegate642_0;
}
