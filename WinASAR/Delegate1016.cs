using System;

// Token: 0x02000608 RID: 1544
internal sealed class Delegate1016 : MulticastDelegate
{
	// Token: 0x060027B4 RID: 10164
	public extern object Invoke(Type type_0, short short_0);

	// Token: 0x060027B5 RID: 10165 RVA: 0x0000E662 File Offset: 0x0000C862
	public static object smethod_0(Type type_0, short short_0, Delegate1016 delegate1016_1)
	{
		return delegate1016_1(type_0, short_0);
	}

	// Token: 0x060027B6 RID: 10166
	public extern Delegate1016(object object_0, IntPtr intptr_0);

	// Token: 0x060027B7 RID: 10167 RVA: 0x0000E66F File Offset: 0x0000C86F
	static Delegate1016()
	{
		Class15.smethod_14(typeof(Delegate1016).TypeHandle);
	}

	// Token: 0x04000DD8 RID: 3544
	internal static Delegate1016 delegate1016_0;
}
