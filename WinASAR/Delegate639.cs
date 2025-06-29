using System;

// Token: 0x0200048F RID: 1167
internal sealed class Delegate639 : MulticastDelegate
{
	// Token: 0x060021D0 RID: 8656
	public extern void Invoke(Array array_0, Array array_1, int int_0);

	// Token: 0x060021D1 RID: 8657 RVA: 0x0000C111 File Offset: 0x0000A311
	public static void smethod_0(Array array_0, Array array_1, int int_0, Delegate639 delegate639_1)
	{
		delegate639_1(array_0, array_1, int_0);
	}

	// Token: 0x060021D2 RID: 8658
	public extern Delegate639(object object_0, IntPtr intptr_0);

	// Token: 0x060021D3 RID: 8659 RVA: 0x0000C120 File Offset: 0x0000A320
	static Delegate639()
	{
		Class15.smethod_14(typeof(Delegate639).TypeHandle);
	}

	// Token: 0x04000C5F RID: 3167
	internal static Delegate639 delegate639_0;
}
