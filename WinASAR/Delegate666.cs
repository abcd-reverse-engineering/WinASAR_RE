using System;

// Token: 0x020004AA RID: 1194
internal sealed class Delegate666 : MulticastDelegate
{
	// Token: 0x0600223C RID: 8764
	public extern object[] Invoke(object object_0, bool bool_0);

	// Token: 0x0600223D RID: 8765 RVA: 0x0000C3BD File Offset: 0x0000A5BD
	public static object[] smethod_0(object object_0, bool bool_0, Delegate666 delegate666_1)
	{
		return delegate666_1(object_0, bool_0);
	}

	// Token: 0x0600223E RID: 8766
	public extern Delegate666(object object_0, IntPtr intptr_0);

	// Token: 0x0600223F RID: 8767 RVA: 0x0000C3CA File Offset: 0x0000A5CA
	static Delegate666()
	{
		Class15.smethod_14(typeof(Delegate666).TypeHandle);
	}

	// Token: 0x04000C7A RID: 3194
	internal static Delegate666 delegate666_0;
}
