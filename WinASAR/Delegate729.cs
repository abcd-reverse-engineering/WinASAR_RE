using System;
using System.Reflection;

// Token: 0x020004E9 RID: 1257
internal sealed class Delegate729 : MulticastDelegate
{
	// Token: 0x06002338 RID: 9016
	public extern AssemblyName Invoke(object object_0);

	// Token: 0x06002339 RID: 9017 RVA: 0x0000C9E2 File Offset: 0x0000ABE2
	public static AssemblyName smethod_0(object object_0, Delegate729 delegate729_1)
	{
		return delegate729_1(object_0);
	}

	// Token: 0x0600233A RID: 9018
	public extern Delegate729(object object_0, IntPtr intptr_0);

	// Token: 0x0600233B RID: 9019 RVA: 0x0000C9ED File Offset: 0x0000ABED
	static Delegate729()
	{
		Class15.smethod_14(typeof(Delegate729).TypeHandle);
	}

	// Token: 0x04000CB9 RID: 3257
	internal static Delegate729 delegate729_0;
}
