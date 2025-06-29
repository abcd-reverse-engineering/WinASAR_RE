using System;

// Token: 0x020003E0 RID: 992
internal sealed class Delegate464 : MulticastDelegate
{
	// Token: 0x06001F14 RID: 7956
	public extern decimal Invoke(decimal decimal_0, decimal decimal_1);

	// Token: 0x06001F15 RID: 7957 RVA: 0x0000AF83 File Offset: 0x00009183
	public static decimal smethod_0(decimal decimal_0, decimal decimal_1, Delegate464 delegate464_1)
	{
		return delegate464_1(decimal_0, decimal_1);
	}

	// Token: 0x06001F16 RID: 7958
	public extern Delegate464(object object_0, IntPtr intptr_0);

	// Token: 0x06001F17 RID: 7959 RVA: 0x0000AF90 File Offset: 0x00009190
	static Delegate464()
	{
		Class15.smethod_14(typeof(Delegate464).TypeHandle);
	}

	// Token: 0x04000BB0 RID: 2992
	internal static Delegate464 delegate464_0;
}
