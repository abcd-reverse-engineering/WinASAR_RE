using System;

// Token: 0x0200050C RID: 1292
internal sealed class Delegate764 : MulticastDelegate
{
	// Token: 0x060023C4 RID: 9156
	public extern Type Invoke(object object_0, string string_0, string string_1);

	// Token: 0x060023C5 RID: 9157 RVA: 0x0000CD4C File Offset: 0x0000AF4C
	public static Type smethod_0(object object_0, string string_0, string string_1, Delegate764 delegate764_1)
	{
		return delegate764_1(object_0, string_0, string_1);
	}

	// Token: 0x060023C6 RID: 9158
	public extern Delegate764(object object_0, IntPtr intptr_0);

	// Token: 0x060023C7 RID: 9159 RVA: 0x0000CD5B File Offset: 0x0000AF5B
	static Delegate764()
	{
		Class15.smethod_14(typeof(Delegate764).TypeHandle);
	}

	// Token: 0x04000CDC RID: 3292
	internal static Delegate764 delegate764_0;
}
