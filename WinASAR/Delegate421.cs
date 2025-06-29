using System;

// Token: 0x020003B5 RID: 949
internal sealed class Delegate421 : MulticastDelegate
{
	// Token: 0x06001E68 RID: 7784
	public extern Type Invoke(object object_0);

	// Token: 0x06001E69 RID: 7785 RVA: 0x0000AB27 File Offset: 0x00008D27
	public static Type smethod_0(object object_0, Delegate421 delegate421_1)
	{
		return delegate421_1(object_0);
	}

	// Token: 0x06001E6A RID: 7786
	public extern Delegate421(object object_0, IntPtr intptr_0);

	// Token: 0x06001E6B RID: 7787 RVA: 0x0000AB32 File Offset: 0x00008D32
	static Delegate421()
	{
		Class15.smethod_14(typeof(Delegate421).TypeHandle);
	}

	// Token: 0x04000B85 RID: 2949
	internal static Delegate421 delegate421_0;
}
