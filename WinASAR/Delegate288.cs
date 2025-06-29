using System;

// Token: 0x02000330 RID: 816
internal sealed class Delegate288 : MulticastDelegate
{
	// Token: 0x06001C54 RID: 7252
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001C55 RID: 7253 RVA: 0x00009DA5 File Offset: 0x00007FA5
	public static void smethod_0(object object_0, bool bool_0, Delegate288 delegate288_1)
	{
		delegate288_1(object_0, bool_0);
	}

	// Token: 0x06001C56 RID: 7254
	public extern Delegate288(object object_0, IntPtr intptr_0);

	// Token: 0x06001C57 RID: 7255 RVA: 0x00009DB2 File Offset: 0x00007FB2
	static Delegate288()
	{
		Class15.smethod_14(typeof(Delegate288).TypeHandle);
	}

	// Token: 0x04000B00 RID: 2816
	internal static Delegate288 delegate288_0;
}
