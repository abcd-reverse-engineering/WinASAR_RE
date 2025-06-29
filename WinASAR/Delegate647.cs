using System;
using System.Reflection;

// Token: 0x02000497 RID: 1175
internal sealed class Delegate647 : MulticastDelegate
{
	// Token: 0x060021F0 RID: 8688
	public extern MemberInfo[] Invoke(object object_0, string string_0, BindingFlags bindingFlags_0);

	// Token: 0x060021F1 RID: 8689 RVA: 0x0000C1E5 File Offset: 0x0000A3E5
	public static MemberInfo[] smethod_0(object object_0, string string_0, BindingFlags bindingFlags_0, Delegate647 delegate647_1)
	{
		return delegate647_1(object_0, string_0, bindingFlags_0);
	}

	// Token: 0x060021F2 RID: 8690
	public extern Delegate647(object object_0, IntPtr intptr_0);

	// Token: 0x060021F3 RID: 8691 RVA: 0x0000C1F4 File Offset: 0x0000A3F4
	static Delegate647()
	{
		Class15.smethod_14(typeof(Delegate647).TypeHandle);
	}

	// Token: 0x04000C67 RID: 3175
	internal static Delegate647 delegate647_0;
}
