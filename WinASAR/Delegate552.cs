using System;
using System.Reflection;

// Token: 0x02000438 RID: 1080
internal sealed class Delegate552 : MulticastDelegate
{
	// Token: 0x06002074 RID: 8308
	public extern Module Invoke(object object_0);

	// Token: 0x06002075 RID: 8309 RVA: 0x0000B859 File Offset: 0x00009A59
	public static Module smethod_0(object object_0, Delegate552 delegate552_1)
	{
		return delegate552_1(object_0);
	}

	// Token: 0x06002076 RID: 8310
	public extern Delegate552(object object_0, IntPtr intptr_0);

	// Token: 0x06002077 RID: 8311 RVA: 0x0000B864 File Offset: 0x00009A64
	static Delegate552()
	{
		Class15.smethod_14(typeof(Delegate552).TypeHandle);
	}

	// Token: 0x04000C08 RID: 3080
	internal static Delegate552 delegate552_0;
}
