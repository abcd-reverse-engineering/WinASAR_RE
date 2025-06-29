using System;

// Token: 0x0200060B RID: 1547
internal sealed class Delegate1019 : MulticastDelegate
{
	// Token: 0x060027C0 RID: 10176
	public extern object Invoke(Type type_0, sbyte sbyte_0);

	// Token: 0x060027C1 RID: 10177 RVA: 0x0000E6B0 File Offset: 0x0000C8B0
	public static object smethod_0(Type type_0, sbyte sbyte_0, Delegate1019 delegate1019_1)
	{
		return delegate1019_1(type_0, sbyte_0);
	}

	// Token: 0x060027C2 RID: 10178
	public extern Delegate1019(object object_0, IntPtr intptr_0);

	// Token: 0x060027C3 RID: 10179 RVA: 0x0000E6BD File Offset: 0x0000C8BD
	static Delegate1019()
	{
		Class15.smethod_14(typeof(Delegate1019).TypeHandle);
	}

	// Token: 0x04000DDB RID: 3547
	internal static Delegate1019 delegate1019_0;
}
