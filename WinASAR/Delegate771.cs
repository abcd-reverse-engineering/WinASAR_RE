using System;

// Token: 0x02000513 RID: 1299
internal sealed class Delegate771 : MulticastDelegate
{
	// Token: 0x060023E0 RID: 9184
	public extern bool Invoke(string string_0, ref int int_0);

	// Token: 0x060023E1 RID: 9185 RVA: 0x0000CE04 File Offset: 0x0000B004
	public static bool smethod_0(string string_0, ref int int_0, Delegate771 delegate771_1)
	{
		return delegate771_1(string_0, ref int_0);
	}

	// Token: 0x060023E2 RID: 9186
	public extern Delegate771(object object_0, IntPtr intptr_0);

	// Token: 0x060023E3 RID: 9187 RVA: 0x0000CE11 File Offset: 0x0000B011
	static Delegate771()
	{
		Class15.smethod_14(typeof(Delegate771).TypeHandle);
	}

	// Token: 0x04000CE3 RID: 3299
	internal static Delegate771 delegate771_0;
}
