using System;

// Token: 0x02000611 RID: 1553
internal sealed class Delegate1025 : MulticastDelegate
{
	// Token: 0x060027D8 RID: 10200
	public extern string Invoke(ref ulong ulong_0);

	// Token: 0x060027D9 RID: 10201 RVA: 0x0000E742 File Offset: 0x0000C942
	public static string smethod_0(ref ulong ulong_0, Delegate1025 delegate1025_1)
	{
		return delegate1025_1(ref ulong_0);
	}

	// Token: 0x060027DA RID: 10202
	public extern Delegate1025(object object_0, IntPtr intptr_0);

	// Token: 0x060027DB RID: 10203 RVA: 0x0000E74D File Offset: 0x0000C94D
	static Delegate1025()
	{
		Class15.smethod_14(typeof(Delegate1025).TypeHandle);
	}

	// Token: 0x04000DE1 RID: 3553
	internal static Delegate1025 delegate1025_0;
}
