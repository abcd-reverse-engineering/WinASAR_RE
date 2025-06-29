using System;

// Token: 0x0200038E RID: 910
internal sealed class Delegate382 : MulticastDelegate
{
	// Token: 0x06001DCC RID: 7628
	public extern long Invoke(string string_0, int int_0);

	// Token: 0x06001DCD RID: 7629 RVA: 0x0000A73D File Offset: 0x0000893D
	public static long smethod_0(string string_0, int int_0, Delegate382 delegate382_1)
	{
		return delegate382_1(string_0, int_0);
	}

	// Token: 0x06001DCE RID: 7630
	public extern Delegate382(object object_0, IntPtr intptr_0);

	// Token: 0x06001DCF RID: 7631 RVA: 0x0000A74A File Offset: 0x0000894A
	static Delegate382()
	{
		Class15.smethod_14(typeof(Delegate382).TypeHandle);
	}

	// Token: 0x04000B5E RID: 2910
	internal static Delegate382 delegate382_0;
}
