using System;
using System.Text;

// Token: 0x02000366 RID: 870
internal sealed class Delegate342 : MulticastDelegate
{
	// Token: 0x06001D2C RID: 7468
	public extern StringBuilder Invoke(object object_0, string string_0);

	// Token: 0x06001D2D RID: 7469 RVA: 0x0000A325 File Offset: 0x00008525
	public static StringBuilder smethod_0(object object_0, string string_0, Delegate342 delegate342_1)
	{
		return delegate342_1(object_0, string_0);
	}

	// Token: 0x06001D2E RID: 7470
	public extern Delegate342(object object_0, IntPtr intptr_0);

	// Token: 0x06001D2F RID: 7471 RVA: 0x0000A332 File Offset: 0x00008532
	static Delegate342()
	{
		Class15.smethod_14(typeof(Delegate342).TypeHandle);
	}

	// Token: 0x04000B36 RID: 2870
	internal static Delegate342 delegate342_0;
}
