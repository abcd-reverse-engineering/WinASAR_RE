using System;

// Token: 0x0200044F RID: 1103
internal sealed class Delegate575 : MulticastDelegate
{
	// Token: 0x060020D0 RID: 8400
	public extern Type Invoke(object object_0);

	// Token: 0x060020D1 RID: 8401 RVA: 0x0000BAA9 File Offset: 0x00009CA9
	public static Type smethod_0(object object_0, Delegate575 delegate575_1)
	{
		return delegate575_1(object_0);
	}

	// Token: 0x060020D2 RID: 8402
	public extern Delegate575(object object_0, IntPtr intptr_0);

	// Token: 0x060020D3 RID: 8403 RVA: 0x0000BAB4 File Offset: 0x00009CB4
	static Delegate575()
	{
		Class15.smethod_14(typeof(Delegate575).TypeHandle);
	}

	// Token: 0x04000C1F RID: 3103
	internal static Delegate575 delegate575_0;
}
