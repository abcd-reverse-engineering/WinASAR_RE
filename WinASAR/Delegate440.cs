using System;

// Token: 0x020003C8 RID: 968
internal sealed class Delegate440 : MulticastDelegate
{
	// Token: 0x06001EB4 RID: 7860
	public extern bool Invoke(object object_0);

	// Token: 0x06001EB5 RID: 7861 RVA: 0x0000AD11 File Offset: 0x00008F11
	public static bool smethod_0(object object_0, Delegate440 delegate440_1)
	{
		return delegate440_1(object_0);
	}

	// Token: 0x06001EB6 RID: 7862
	public extern Delegate440(object object_0, IntPtr intptr_0);

	// Token: 0x06001EB7 RID: 7863 RVA: 0x0000AD1C File Offset: 0x00008F1C
	static Delegate440()
	{
		Class15.smethod_14(typeof(Delegate440).TypeHandle);
	}

	// Token: 0x04000B98 RID: 2968
	internal static Delegate440 delegate440_0;
}
