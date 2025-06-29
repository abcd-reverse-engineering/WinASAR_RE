using System;

// Token: 0x02000609 RID: 1545
internal sealed class Delegate1017 : MulticastDelegate
{
	// Token: 0x060027B8 RID: 10168
	public extern object Invoke(Type type_0, ushort ushort_0);

	// Token: 0x060027B9 RID: 10169 RVA: 0x0000E67C File Offset: 0x0000C87C
	public static object smethod_0(Type type_0, ushort ushort_0, Delegate1017 delegate1017_1)
	{
		return delegate1017_1(type_0, ushort_0);
	}

	// Token: 0x060027BA RID: 10170
	public extern Delegate1017(object object_0, IntPtr intptr_0);

	// Token: 0x060027BB RID: 10171 RVA: 0x0000E689 File Offset: 0x0000C889
	static Delegate1017()
	{
		Class15.smethod_14(typeof(Delegate1017).TypeHandle);
	}

	// Token: 0x04000DD9 RID: 3545
	internal static Delegate1017 delegate1017_0;
}
