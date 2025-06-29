using System;

// Token: 0x02000607 RID: 1543
internal sealed class Delegate1015 : MulticastDelegate
{
	// Token: 0x060027B0 RID: 10160
	public extern object Invoke(Type type_0, uint uint_0);

	// Token: 0x060027B1 RID: 10161 RVA: 0x0000E648 File Offset: 0x0000C848
	public static object smethod_0(Type type_0, uint uint_0, Delegate1015 delegate1015_1)
	{
		return delegate1015_1(type_0, uint_0);
	}

	// Token: 0x060027B2 RID: 10162
	public extern Delegate1015(object object_0, IntPtr intptr_0);

	// Token: 0x060027B3 RID: 10163 RVA: 0x0000E655 File Offset: 0x0000C855
	static Delegate1015()
	{
		Class15.smethod_14(typeof(Delegate1015).TypeHandle);
	}

	// Token: 0x04000DD7 RID: 3543
	internal static Delegate1015 delegate1015_0;
}
