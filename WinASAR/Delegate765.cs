using System;

// Token: 0x0200050D RID: 1293
internal sealed class Delegate765 : MulticastDelegate
{
	// Token: 0x060023C8 RID: 9160
	public extern void Invoke(object object_0, Type type_0, ref string string_0, ref string string_1);

	// Token: 0x060023C9 RID: 9161 RVA: 0x0000CD68 File Offset: 0x0000AF68
	public static void smethod_0(object object_0, Type type_0, ref string string_0, ref string string_1, Delegate765 delegate765_1)
	{
		delegate765_1(object_0, type_0, ref string_0, ref string_1);
	}

	// Token: 0x060023CA RID: 9162
	public extern Delegate765(object object_0, IntPtr intptr_0);

	// Token: 0x060023CB RID: 9163 RVA: 0x0000CD79 File Offset: 0x0000AF79
	static Delegate765()
	{
		Class15.smethod_14(typeof(Delegate765).TypeHandle);
	}

	// Token: 0x04000CDD RID: 3293
	internal static Delegate765 delegate765_0;
}
