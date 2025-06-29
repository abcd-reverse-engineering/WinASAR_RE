using System;

// Token: 0x02000491 RID: 1169
internal sealed class Delegate641 : MulticastDelegate
{
	// Token: 0x060021D8 RID: 8664
	public extern bool Invoke(ref decimal decimal_0, decimal decimal_1);

	// Token: 0x060021D9 RID: 8665 RVA: 0x0000C147 File Offset: 0x0000A347
	public static bool smethod_0(ref decimal decimal_0, decimal decimal_1, Delegate641 delegate641_1)
	{
		return delegate641_1(ref decimal_0, decimal_1);
	}

	// Token: 0x060021DA RID: 8666
	public extern Delegate641(object object_0, IntPtr intptr_0);

	// Token: 0x060021DB RID: 8667 RVA: 0x0000C154 File Offset: 0x0000A354
	static Delegate641()
	{
		Class15.smethod_14(typeof(Delegate641).TypeHandle);
	}

	// Token: 0x04000C61 RID: 3169
	internal static Delegate641 delegate641_0;
}
