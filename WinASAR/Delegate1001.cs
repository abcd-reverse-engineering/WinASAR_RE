using System;

// Token: 0x020005F9 RID: 1529
internal sealed class Delegate1001 : MulticastDelegate
{
	// Token: 0x06002778 RID: 10104
	public extern Type Invoke(object object_0, int int_0);

	// Token: 0x06002779 RID: 10105 RVA: 0x0000E4EA File Offset: 0x0000C6EA
	public static Type smethod_0(object object_0, int int_0, Delegate1001 delegate1001_1)
	{
		return delegate1001_1(object_0, int_0);
	}

	// Token: 0x0600277A RID: 10106
	public extern Delegate1001(object object_0, IntPtr intptr_0);

	// Token: 0x0600277B RID: 10107 RVA: 0x0000E4F7 File Offset: 0x0000C6F7
	static Delegate1001()
	{
		Class15.smethod_14(typeof(Delegate1001).TypeHandle);
	}

	// Token: 0x04000DC9 RID: 3529
	internal static Delegate1001 delegate1001_0;
}
