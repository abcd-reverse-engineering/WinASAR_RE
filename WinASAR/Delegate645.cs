using System;

// Token: 0x02000495 RID: 1173
internal sealed class Delegate645 : MulticastDelegate
{
	// Token: 0x060021E8 RID: 8680
	public extern string Invoke(object object_0, int int_0);

	// Token: 0x060021E9 RID: 8681 RVA: 0x0000C1B1 File Offset: 0x0000A3B1
	public static string smethod_0(object object_0, int int_0, Delegate645 delegate645_1)
	{
		return delegate645_1(object_0, int_0);
	}

	// Token: 0x060021EA RID: 8682
	public extern Delegate645(object object_0, IntPtr intptr_0);

	// Token: 0x060021EB RID: 8683 RVA: 0x0000C1BE File Offset: 0x0000A3BE
	static Delegate645()
	{
		Class15.smethod_14(typeof(Delegate645).TypeHandle);
	}

	// Token: 0x04000C65 RID: 3173
	internal static Delegate645 delegate645_0;
}
