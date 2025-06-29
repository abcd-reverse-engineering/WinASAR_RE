using System;

// Token: 0x02000258 RID: 600
internal sealed class Delegate72 : MulticastDelegate
{
	// Token: 0x060018F4 RID: 6388
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x060018F5 RID: 6389 RVA: 0x00008865 File Offset: 0x00006A65
	public static void smethod_0(object object_0, bool bool_0, Delegate72 delegate72_1)
	{
		delegate72_1(object_0, bool_0);
	}

	// Token: 0x060018F6 RID: 6390
	public extern Delegate72(object object_0, IntPtr intptr_0);

	// Token: 0x060018F7 RID: 6391 RVA: 0x00008872 File Offset: 0x00006A72
	static Delegate72()
	{
		Class15.smethod_14(typeof(Delegate72).TypeHandle);
	}

	// Token: 0x04000A28 RID: 2600
	internal static Delegate72 delegate72_0;
}
