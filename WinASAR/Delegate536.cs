using System;

// Token: 0x02000428 RID: 1064
internal sealed class Delegate536 : MulticastDelegate
{
	// Token: 0x06002034 RID: 8244
	public extern Type Invoke(object object_0);

	// Token: 0x06002035 RID: 8245 RVA: 0x0000B6C3 File Offset: 0x000098C3
	public static Type smethod_0(object object_0, Delegate536 delegate536_1)
	{
		return delegate536_1(object_0);
	}

	// Token: 0x06002036 RID: 8246
	public extern Delegate536(object object_0, IntPtr intptr_0);

	// Token: 0x06002037 RID: 8247 RVA: 0x0000B6CE File Offset: 0x000098CE
	static Delegate536()
	{
		Class15.smethod_14(typeof(Delegate536).TypeHandle);
	}

	// Token: 0x04000BF8 RID: 3064
	internal static Delegate536 delegate536_0;
}
