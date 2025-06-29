using System;

// Token: 0x0200029B RID: 667
internal sealed class Delegate139 : MulticastDelegate
{
	// Token: 0x06001A00 RID: 6656
	public extern DateTime Invoke(object object_0);

	// Token: 0x06001A01 RID: 6657 RVA: 0x00008EF3 File Offset: 0x000070F3
	public static DateTime smethod_0(object object_0, Delegate139 delegate139_1)
	{
		return delegate139_1(object_0);
	}

	// Token: 0x06001A02 RID: 6658
	public extern Delegate139(object object_0, IntPtr intptr_0);

	// Token: 0x06001A03 RID: 6659 RVA: 0x00008EFE File Offset: 0x000070FE
	static Delegate139()
	{
		Class15.smethod_14(typeof(Delegate139).TypeHandle);
	}

	// Token: 0x04000A6B RID: 2667
	internal static Delegate139 delegate139_0;
}
