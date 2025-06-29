using System;

// Token: 0x02000288 RID: 648
internal sealed class Delegate120 : MulticastDelegate
{
	// Token: 0x060019B4 RID: 6580
	public extern string[] Invoke(string string_0);

	// Token: 0x060019B5 RID: 6581 RVA: 0x00008D21 File Offset: 0x00006F21
	public static string[] smethod_0(string string_0, Delegate120 delegate120_1)
	{
		return delegate120_1(string_0);
	}

	// Token: 0x060019B6 RID: 6582
	public extern Delegate120(object object_0, IntPtr intptr_0);

	// Token: 0x060019B7 RID: 6583 RVA: 0x00008D2C File Offset: 0x00006F2C
	static Delegate120()
	{
		Class15.smethod_14(typeof(Delegate120).TypeHandle);
	}

	// Token: 0x04000A58 RID: 2648
	internal static Delegate120 delegate120_0;
}
