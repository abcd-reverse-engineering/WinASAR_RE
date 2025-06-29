using System;

// Token: 0x02000618 RID: 1560
internal sealed class Delegate1032 : MulticastDelegate
{
	// Token: 0x060027F4 RID: 10228
	public extern object Invoke(object object_0, int int_0);

	// Token: 0x060027F5 RID: 10229 RVA: 0x0000E7EA File Offset: 0x0000C9EA
	public static object smethod_0(object object_0, int int_0, Delegate1032 delegate1032_1)
	{
		return delegate1032_1(object_0, int_0);
	}

	// Token: 0x060027F6 RID: 10230
	public extern Delegate1032(object object_0, IntPtr intptr_0);

	// Token: 0x060027F7 RID: 10231 RVA: 0x0000E7F7 File Offset: 0x0000C9F7
	static Delegate1032()
	{
		Class15.smethod_14(typeof(Delegate1032).TypeHandle);
	}

	// Token: 0x04000DE8 RID: 3560
	internal static Delegate1032 delegate1032_0;
}
