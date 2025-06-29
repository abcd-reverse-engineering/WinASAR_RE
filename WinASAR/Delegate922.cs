using System;

// Token: 0x020005AA RID: 1450
internal sealed class Delegate922 : MulticastDelegate
{
	// Token: 0x0600263C RID: 9788
	public extern string Invoke(object object_0);

	// Token: 0x0600263D RID: 9789 RVA: 0x0000DCEA File Offset: 0x0000BEEA
	public static string smethod_0(object object_0, Delegate922 delegate922_1)
	{
		return delegate922_1(object_0);
	}

	// Token: 0x0600263E RID: 9790
	public extern Delegate922(object object_0, IntPtr intptr_0);

	// Token: 0x0600263F RID: 9791 RVA: 0x0000DCF5 File Offset: 0x0000BEF5
	static Delegate922()
	{
		Class15.smethod_14(typeof(Delegate922).TypeHandle);
	}

	// Token: 0x04000D7A RID: 3450
	internal static Delegate922 delegate922_0;
}
