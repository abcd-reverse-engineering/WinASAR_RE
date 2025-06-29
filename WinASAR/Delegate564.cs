using System;

// Token: 0x02000444 RID: 1092
internal sealed class Delegate564 : MulticastDelegate
{
	// Token: 0x060020A4 RID: 8356
	public extern bool Invoke(object object_0);

	// Token: 0x060020A5 RID: 8357 RVA: 0x0000B98D File Offset: 0x00009B8D
	public static bool smethod_0(object object_0, Delegate564 delegate564_1)
	{
		return delegate564_1(object_0);
	}

	// Token: 0x060020A6 RID: 8358
	public extern Delegate564(object object_0, IntPtr intptr_0);

	// Token: 0x060020A7 RID: 8359 RVA: 0x0000B998 File Offset: 0x00009B98
	static Delegate564()
	{
		Class15.smethod_14(typeof(Delegate564).TypeHandle);
	}

	// Token: 0x04000C14 RID: 3092
	internal static Delegate564 delegate564_0;
}
