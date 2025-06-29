using System;

// Token: 0x0200029A RID: 666
internal sealed class Delegate138 : MulticastDelegate
{
	// Token: 0x060019FC RID: 6652
	public extern DateTime Invoke(object object_0);

	// Token: 0x060019FD RID: 6653 RVA: 0x00008EDB File Offset: 0x000070DB
	public static DateTime smethod_0(object object_0, Delegate138 delegate138_1)
	{
		return delegate138_1(object_0);
	}

	// Token: 0x060019FE RID: 6654
	public extern Delegate138(object object_0, IntPtr intptr_0);

	// Token: 0x060019FF RID: 6655 RVA: 0x00008EE6 File Offset: 0x000070E6
	static Delegate138()
	{
		Class15.smethod_14(typeof(Delegate138).TypeHandle);
	}

	// Token: 0x04000A6A RID: 2666
	internal static Delegate138 delegate138_0;
}
