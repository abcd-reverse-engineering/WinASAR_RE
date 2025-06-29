using System;

// Token: 0x0200048D RID: 1165
internal sealed class Delegate637 : MulticastDelegate
{
	// Token: 0x060021C8 RID: 8648
	public extern Type Invoke(object object_0);

	// Token: 0x060021C9 RID: 8649 RVA: 0x0000C0E1 File Offset: 0x0000A2E1
	public static Type smethod_0(object object_0, Delegate637 delegate637_1)
	{
		return delegate637_1(object_0);
	}

	// Token: 0x060021CA RID: 8650
	public extern Delegate637(object object_0, IntPtr intptr_0);

	// Token: 0x060021CB RID: 8651 RVA: 0x0000C0EC File Offset: 0x0000A2EC
	static Delegate637()
	{
		Class15.smethod_14(typeof(Delegate637).TypeHandle);
	}

	// Token: 0x04000C5D RID: 3165
	internal static Delegate637 delegate637_0;
}
