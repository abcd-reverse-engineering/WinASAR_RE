using System;

// Token: 0x02000299 RID: 665
internal sealed class Delegate137 : MulticastDelegate
{
	// Token: 0x060019F8 RID: 6648
	public extern DateTime Invoke(object object_0);

	// Token: 0x060019F9 RID: 6649 RVA: 0x00008EC3 File Offset: 0x000070C3
	public static DateTime smethod_0(object object_0, Delegate137 delegate137_1)
	{
		return delegate137_1(object_0);
	}

	// Token: 0x060019FA RID: 6650
	public extern Delegate137(object object_0, IntPtr intptr_0);

	// Token: 0x060019FB RID: 6651 RVA: 0x00008ECE File Offset: 0x000070CE
	static Delegate137()
	{
		Class15.smethod_14(typeof(Delegate137).TypeHandle);
	}

	// Token: 0x04000A69 RID: 2665
	internal static Delegate137 delegate137_0;
}
