using System;

// Token: 0x020005A0 RID: 1440
internal sealed class Delegate912 : MulticastDelegate
{
	// Token: 0x06002614 RID: 9748
	public extern string Invoke(object object_0);

	// Token: 0x06002615 RID: 9749 RVA: 0x0000DBF4 File Offset: 0x0000BDF4
	public static string smethod_0(object object_0, Delegate912 delegate912_1)
	{
		return delegate912_1(object_0);
	}

	// Token: 0x06002616 RID: 9750
	public extern Delegate912(object object_0, IntPtr intptr_0);

	// Token: 0x06002617 RID: 9751 RVA: 0x0000DBFF File Offset: 0x0000BDFF
	static Delegate912()
	{
		Class15.smethod_14(typeof(Delegate912).TypeHandle);
	}

	// Token: 0x04000D70 RID: 3440
	internal static Delegate912 delegate912_0;
}
