using System;

// Token: 0x02000484 RID: 1156
internal sealed class Delegate628 : MulticastDelegate
{
	// Token: 0x060021A4 RID: 8612
	public extern Type Invoke(object object_0, string string_0);

	// Token: 0x060021A5 RID: 8613 RVA: 0x0000BFFB File Offset: 0x0000A1FB
	public static Type smethod_0(object object_0, string string_0, Delegate628 delegate628_1)
	{
		return delegate628_1(object_0, string_0);
	}

	// Token: 0x060021A6 RID: 8614
	public extern Delegate628(object object_0, IntPtr intptr_0);

	// Token: 0x060021A7 RID: 8615 RVA: 0x0000C008 File Offset: 0x0000A208
	static Delegate628()
	{
		Class15.smethod_14(typeof(Delegate628).TypeHandle);
	}

	// Token: 0x04000C54 RID: 3156
	internal static Delegate628 delegate628_0;
}
