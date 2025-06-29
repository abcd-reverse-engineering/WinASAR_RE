using System;

// Token: 0x02000443 RID: 1091
internal sealed class Delegate563 : MulticastDelegate
{
	// Token: 0x060020A0 RID: 8352
	public extern bool Invoke(object object_0);

	// Token: 0x060020A1 RID: 8353 RVA: 0x0000B975 File Offset: 0x00009B75
	public static bool smethod_0(object object_0, Delegate563 delegate563_1)
	{
		return delegate563_1(object_0);
	}

	// Token: 0x060020A2 RID: 8354
	public extern Delegate563(object object_0, IntPtr intptr_0);

	// Token: 0x060020A3 RID: 8355 RVA: 0x0000B980 File Offset: 0x00009B80
	static Delegate563()
	{
		Class15.smethod_14(typeof(Delegate563).TypeHandle);
	}

	// Token: 0x04000C13 RID: 3091
	internal static Delegate563 delegate563_0;
}
