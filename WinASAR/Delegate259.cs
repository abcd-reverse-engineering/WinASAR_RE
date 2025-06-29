using System;

// Token: 0x02000313 RID: 787
internal sealed class Delegate259 : MulticastDelegate
{
	// Token: 0x06001BE0 RID: 7136
	public extern bool Invoke(object object_0);

	// Token: 0x06001BE1 RID: 7137 RVA: 0x00009AD1 File Offset: 0x00007CD1
	public static bool smethod_0(object object_0, Delegate259 delegate259_1)
	{
		return delegate259_1(object_0);
	}

	// Token: 0x06001BE2 RID: 7138
	public extern Delegate259(object object_0, IntPtr intptr_0);

	// Token: 0x06001BE3 RID: 7139 RVA: 0x00009ADC File Offset: 0x00007CDC
	static Delegate259()
	{
		Class15.smethod_14(typeof(Delegate259).TypeHandle);
	}

	// Token: 0x04000AE3 RID: 2787
	internal static Delegate259 delegate259_0;
}
