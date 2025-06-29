using System;

// Token: 0x020005A5 RID: 1445
internal sealed class Delegate917 : MulticastDelegate
{
	// Token: 0x06002628 RID: 9768
	public extern void Invoke(object object_0, object object_1);

	// Token: 0x06002629 RID: 9769 RVA: 0x0000DC6E File Offset: 0x0000BE6E
	public static void smethod_0(object object_0, object object_1, Delegate917 delegate917_1)
	{
		delegate917_1(object_0, object_1);
	}

	// Token: 0x0600262A RID: 9770
	public extern Delegate917(object object_0, IntPtr intptr_0);

	// Token: 0x0600262B RID: 9771 RVA: 0x0000DC7B File Offset: 0x0000BE7B
	static Delegate917()
	{
		Class15.smethod_14(typeof(Delegate917).TypeHandle);
	}

	// Token: 0x04000D75 RID: 3445
	internal static Delegate917 delegate917_0;
}
