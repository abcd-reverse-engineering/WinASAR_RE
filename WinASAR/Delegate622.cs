using System;

// Token: 0x0200047E RID: 1150
internal sealed class Delegate622 : MulticastDelegate
{
	// Token: 0x0600218C RID: 8588
	public extern bool Invoke(object object_0);

	// Token: 0x0600218D RID: 8589 RVA: 0x0000BF63 File Offset: 0x0000A163
	public static bool smethod_0(object object_0, Delegate622 delegate622_1)
	{
		return delegate622_1(object_0);
	}

	// Token: 0x0600218E RID: 8590
	public extern Delegate622(object object_0, IntPtr intptr_0);

	// Token: 0x0600218F RID: 8591 RVA: 0x0000BF6E File Offset: 0x0000A16E
	static Delegate622()
	{
		Class15.smethod_14(typeof(Delegate622).TypeHandle);
	}

	// Token: 0x04000C4E RID: 3150
	internal static Delegate622 delegate622_0;
}
