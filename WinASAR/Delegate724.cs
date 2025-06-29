using System;
using System.Reflection;

// Token: 0x020004E4 RID: 1252
internal sealed class Delegate724 : MulticastDelegate
{
	// Token: 0x06002324 RID: 8996
	public extern Assembly Invoke(string string_0);

	// Token: 0x06002325 RID: 8997 RVA: 0x0000C96A File Offset: 0x0000AB6A
	public static Assembly smethod_0(string string_0, Delegate724 delegate724_1)
	{
		return delegate724_1(string_0);
	}

	// Token: 0x06002326 RID: 8998
	public extern Delegate724(object object_0, IntPtr intptr_0);

	// Token: 0x06002327 RID: 8999 RVA: 0x0000C975 File Offset: 0x0000AB75
	static Delegate724()
	{
		Class15.smethod_14(typeof(Delegate724).TypeHandle);
	}

	// Token: 0x04000CB4 RID: 3252
	internal static Delegate724 delegate724_0;
}
