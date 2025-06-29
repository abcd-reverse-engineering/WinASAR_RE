using System;

// Token: 0x02000498 RID: 1176
internal sealed class Delegate648 : MulticastDelegate
{
	// Token: 0x060021F4 RID: 8692
	public extern bool Invoke(object object_0);

	// Token: 0x060021F5 RID: 8693 RVA: 0x0000C201 File Offset: 0x0000A401
	public static bool smethod_0(object object_0, Delegate648 delegate648_1)
	{
		return delegate648_1(object_0);
	}

	// Token: 0x060021F6 RID: 8694
	public extern Delegate648(object object_0, IntPtr intptr_0);

	// Token: 0x060021F7 RID: 8695 RVA: 0x0000C20C File Offset: 0x0000A40C
	static Delegate648()
	{
		Class15.smethod_14(typeof(Delegate648).TypeHandle);
	}

	// Token: 0x04000C68 RID: 3176
	internal static Delegate648 delegate648_0;
}
