using System;

// Token: 0x020004B4 RID: 1204
internal sealed class Delegate676 : MulticastDelegate
{
	// Token: 0x06002264 RID: 8804
	public extern object[] Invoke(object object_0, Type type_0, bool bool_0);

	// Token: 0x06002265 RID: 8805 RVA: 0x0000C4C5 File Offset: 0x0000A6C5
	public static object[] smethod_0(object object_0, Type type_0, bool bool_0, Delegate676 delegate676_1)
	{
		return delegate676_1(object_0, type_0, bool_0);
	}

	// Token: 0x06002266 RID: 8806
	public extern Delegate676(object object_0, IntPtr intptr_0);

	// Token: 0x06002267 RID: 8807 RVA: 0x0000C4D4 File Offset: 0x0000A6D4
	static Delegate676()
	{
		Class15.smethod_14(typeof(Delegate676).TypeHandle);
	}

	// Token: 0x04000C84 RID: 3204
	internal static Delegate676 delegate676_0;
}
