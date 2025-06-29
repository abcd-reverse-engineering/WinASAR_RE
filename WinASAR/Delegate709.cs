using System;

// Token: 0x020004D5 RID: 1237
internal sealed class Delegate709 : MulticastDelegate
{
	// Token: 0x060022E8 RID: 8936
	public extern string Invoke(object object_0);

	// Token: 0x060022E9 RID: 8937 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
	public static string smethod_0(object object_0, Delegate709 delegate709_1)
	{
		return delegate709_1(object_0);
	}

	// Token: 0x060022EA RID: 8938
	public extern Delegate709(object object_0, IntPtr intptr_0);

	// Token: 0x060022EB RID: 8939 RVA: 0x0000C803 File Offset: 0x0000AA03
	static Delegate709()
	{
		Class15.smethod_14(typeof(Delegate709).TypeHandle);
	}

	// Token: 0x04000CA5 RID: 3237
	internal static Delegate709 delegate709_0;
}
