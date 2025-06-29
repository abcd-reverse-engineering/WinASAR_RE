using System;
using System.Reflection;

// Token: 0x020004AF RID: 1199
internal sealed class Delegate671 : MulticastDelegate
{
	// Token: 0x06002250 RID: 8784
	public extern Attribute[] Invoke(Module module_0, bool bool_0);

	// Token: 0x06002251 RID: 8785 RVA: 0x0000C43F File Offset: 0x0000A63F
	public static Attribute[] smethod_0(Module module_0, bool bool_0, Delegate671 delegate671_1)
	{
		return delegate671_1(module_0, bool_0);
	}

	// Token: 0x06002252 RID: 8786
	public extern Delegate671(object object_0, IntPtr intptr_0);

	// Token: 0x06002253 RID: 8787 RVA: 0x0000C44C File Offset: 0x0000A64C
	static Delegate671()
	{
		Class15.smethod_14(typeof(Delegate671).TypeHandle);
	}

	// Token: 0x04000C7F RID: 3199
	internal static Delegate671 delegate671_0;
}
