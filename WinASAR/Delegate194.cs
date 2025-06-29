using System;
using System.Windows.Forms;

// Token: 0x020002D2 RID: 722
internal sealed class Delegate194 : MulticastDelegate
{
	// Token: 0x06001ADC RID: 6876
	public extern Keys Invoke(object object_0);

	// Token: 0x06001ADD RID: 6877 RVA: 0x00009463 File Offset: 0x00007663
	public static Keys smethod_0(object object_0, Delegate194 delegate194_1)
	{
		return delegate194_1(object_0);
	}

	// Token: 0x06001ADE RID: 6878
	public extern Delegate194(object object_0, IntPtr intptr_0);

	// Token: 0x06001ADF RID: 6879 RVA: 0x0000946E File Offset: 0x0000766E
	static Delegate194()
	{
		Class15.smethod_14(typeof(Delegate194).TypeHandle);
	}

	// Token: 0x04000AA2 RID: 2722
	internal static Delegate194 delegate194_0;
}
