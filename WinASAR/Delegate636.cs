using System;

// Token: 0x0200048C RID: 1164
internal sealed class Delegate636 : MulticastDelegate
{
	// Token: 0x060021C4 RID: 8644
	public extern bool Invoke(object object_0);

	// Token: 0x060021C5 RID: 8645 RVA: 0x0000C0C9 File Offset: 0x0000A2C9
	public static bool smethod_0(object object_0, Delegate636 delegate636_1)
	{
		return delegate636_1(object_0);
	}

	// Token: 0x060021C6 RID: 8646
	public extern Delegate636(object object_0, IntPtr intptr_0);

	// Token: 0x060021C7 RID: 8647 RVA: 0x0000C0D4 File Offset: 0x0000A2D4
	static Delegate636()
	{
		Class15.smethod_14(typeof(Delegate636).TypeHandle);
	}

	// Token: 0x04000C5C RID: 3164
	internal static Delegate636 delegate636_0;
}
