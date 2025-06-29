using System;

// Token: 0x02000554 RID: 1364
internal sealed class Delegate836 : MulticastDelegate
{
	// Token: 0x060024E4 RID: 9444
	public extern Type Invoke(object object_0);

	// Token: 0x060024E5 RID: 9445 RVA: 0x0000D472 File Offset: 0x0000B672
	public static Type smethod_0(object object_0, Delegate836 delegate836_1)
	{
		return delegate836_1(object_0);
	}

	// Token: 0x060024E6 RID: 9446
	public extern Delegate836(object object_0, IntPtr intptr_0);

	// Token: 0x060024E7 RID: 9447 RVA: 0x0000D47D File Offset: 0x0000B67D
	static Delegate836()
	{
		Class15.smethod_14(typeof(Delegate836).TypeHandle);
	}

	// Token: 0x04000D24 RID: 3364
	internal static Delegate836 delegate836_0;
}
