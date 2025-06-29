using System;

// Token: 0x02000515 RID: 1301
internal sealed class Delegate773 : MulticastDelegate
{
	// Token: 0x060023E8 RID: 9192
	public extern int Invoke(object object_0);

	// Token: 0x060023E9 RID: 9193 RVA: 0x0000CE38 File Offset: 0x0000B038
	public static int smethod_0(object object_0, Delegate773 delegate773_1)
	{
		return delegate773_1(object_0);
	}

	// Token: 0x060023EA RID: 9194
	public extern Delegate773(object object_0, IntPtr intptr_0);

	// Token: 0x060023EB RID: 9195 RVA: 0x0000CE43 File Offset: 0x0000B043
	static Delegate773()
	{
		Class15.smethod_14(typeof(Delegate773).TypeHandle);
	}

	// Token: 0x04000CE5 RID: 3301
	internal static Delegate773 delegate773_0;
}
