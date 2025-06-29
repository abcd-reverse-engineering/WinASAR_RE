using System;

// Token: 0x0200028F RID: 655
internal sealed class Delegate127 : MulticastDelegate
{
	// Token: 0x060019D0 RID: 6608
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x060019D1 RID: 6609 RVA: 0x00008DCB File Offset: 0x00006FCB
	public static void smethod_0(object object_0, string string_0, Delegate127 delegate127_1)
	{
		delegate127_1(object_0, string_0);
	}

	// Token: 0x060019D2 RID: 6610
	public extern Delegate127(object object_0, IntPtr intptr_0);

	// Token: 0x060019D3 RID: 6611 RVA: 0x00008DD8 File Offset: 0x00006FD8
	static Delegate127()
	{
		Class15.smethod_14(typeof(Delegate127).TypeHandle);
	}

	// Token: 0x04000A5F RID: 2655
	internal static Delegate127 delegate127_0;
}
