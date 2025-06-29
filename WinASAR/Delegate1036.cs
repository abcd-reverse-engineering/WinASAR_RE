using System;

// Token: 0x0200061C RID: 1564
internal sealed class Delegate1036 : MulticastDelegate
{
	// Token: 0x06002804 RID: 10244
	public extern Type Invoke(object object_0);

	// Token: 0x06002805 RID: 10245 RVA: 0x0000E84E File Offset: 0x0000CA4E
	public static Type smethod_0(object object_0, Delegate1036 delegate1036_1)
	{
		return delegate1036_1(object_0);
	}

	// Token: 0x06002806 RID: 10246
	public extern Delegate1036(object object_0, IntPtr intptr_0);

	// Token: 0x06002807 RID: 10247 RVA: 0x0000E859 File Offset: 0x0000CA59
	static Delegate1036()
	{
		Class15.smethod_14(typeof(Delegate1036).TypeHandle);
	}

	// Token: 0x04000DEC RID: 3564
	internal static Delegate1036 delegate1036_0;
}
