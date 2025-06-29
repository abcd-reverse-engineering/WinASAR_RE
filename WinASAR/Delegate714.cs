using System;

// Token: 0x020004DA RID: 1242
internal sealed class Delegate714 : MulticastDelegate
{
	// Token: 0x060022FC RID: 8956
	public extern string Invoke(object object_0);

	// Token: 0x060022FD RID: 8957 RVA: 0x0000C872 File Offset: 0x0000AA72
	public static string smethod_0(object object_0, Delegate714 delegate714_1)
	{
		return delegate714_1(object_0);
	}

	// Token: 0x060022FE RID: 8958
	public extern Delegate714(object object_0, IntPtr intptr_0);

	// Token: 0x060022FF RID: 8959 RVA: 0x0000C87D File Offset: 0x0000AA7D
	static Delegate714()
	{
		Class15.smethod_14(typeof(Delegate714).TypeHandle);
	}

	// Token: 0x04000CAA RID: 3242
	internal static Delegate714 delegate714_0;
}
