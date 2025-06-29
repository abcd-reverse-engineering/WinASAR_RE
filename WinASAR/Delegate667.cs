using System;
using System.Reflection;

// Token: 0x020004AB RID: 1195
internal sealed class Delegate667 : MulticastDelegate
{
	// Token: 0x06002240 RID: 8768
	public extern Attribute[] Invoke(Assembly assembly_0);

	// Token: 0x06002241 RID: 8769 RVA: 0x0000C3D7 File Offset: 0x0000A5D7
	public static Attribute[] smethod_0(Assembly assembly_0, Delegate667 delegate667_1)
	{
		return delegate667_1(assembly_0);
	}

	// Token: 0x06002242 RID: 8770
	public extern Delegate667(object object_0, IntPtr intptr_0);

	// Token: 0x06002243 RID: 8771 RVA: 0x0000C3E2 File Offset: 0x0000A5E2
	static Delegate667()
	{
		Class15.smethod_14(typeof(Delegate667).TypeHandle);
	}

	// Token: 0x04000C7B RID: 3195
	internal static Delegate667 delegate667_0;
}
