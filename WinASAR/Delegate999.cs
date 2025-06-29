using System;

// Token: 0x020005F7 RID: 1527
internal sealed class Delegate999 : MulticastDelegate
{
	// Token: 0x06002770 RID: 10096
	public extern Type Invoke(object object_0);

	// Token: 0x06002771 RID: 10097 RVA: 0x0000E4BA File Offset: 0x0000C6BA
	public static Type smethod_0(object object_0, Delegate999 delegate999_1)
	{
		return delegate999_1(object_0);
	}

	// Token: 0x06002772 RID: 10098
	public extern Delegate999(object object_0, IntPtr intptr_0);

	// Token: 0x06002773 RID: 10099 RVA: 0x0000E4C5 File Offset: 0x0000C6C5
	static Delegate999()
	{
		Class15.smethod_14(typeof(Delegate999).TypeHandle);
	}

	// Token: 0x04000DC7 RID: 3527
	internal static Delegate999 delegate999_0;
}
