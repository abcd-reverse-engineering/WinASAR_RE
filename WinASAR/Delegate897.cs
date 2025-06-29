using System;

// Token: 0x02000591 RID: 1425
internal sealed class Delegate897 : MulticastDelegate
{
	// Token: 0x060025D8 RID: 9688
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x060025D9 RID: 9689 RVA: 0x0000DA82 File Offset: 0x0000BC82
	public static void smethod_0(object object_0, string string_0, Delegate897 delegate897_1)
	{
		delegate897_1(object_0, string_0);
	}

	// Token: 0x060025DA RID: 9690
	public extern Delegate897(object object_0, IntPtr intptr_0);

	// Token: 0x060025DB RID: 9691 RVA: 0x0000DA8F File Offset: 0x0000BC8F
	static Delegate897()
	{
		Class15.smethod_14(typeof(Delegate897).TypeHandle);
	}

	// Token: 0x04000D61 RID: 3425
	internal static Delegate897 delegate897_0;
}
