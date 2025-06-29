using System;

// Token: 0x0200032F RID: 815
internal sealed class Delegate287 : MulticastDelegate
{
	// Token: 0x06001C50 RID: 7248
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001C51 RID: 7249 RVA: 0x00009D8B File Offset: 0x00007F8B
	public static void smethod_0(object object_0, bool bool_0, Delegate287 delegate287_1)
	{
		delegate287_1(object_0, bool_0);
	}

	// Token: 0x06001C52 RID: 7250
	public extern Delegate287(object object_0, IntPtr intptr_0);

	// Token: 0x06001C53 RID: 7251 RVA: 0x00009D98 File Offset: 0x00007F98
	static Delegate287()
	{
		Class15.smethod_14(typeof(Delegate287).TypeHandle);
	}

	// Token: 0x04000AFF RID: 2815
	internal static Delegate287 delegate287_0;
}
