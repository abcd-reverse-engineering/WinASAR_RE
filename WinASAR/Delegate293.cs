using System;

// Token: 0x02000335 RID: 821
internal sealed class Delegate293 : MulticastDelegate
{
	// Token: 0x06001C68 RID: 7272
	public extern object Invoke(object object_0, object object_1, object[] object_2);

	// Token: 0x06001C69 RID: 7273 RVA: 0x00009E25 File Offset: 0x00008025
	public static object smethod_0(object object_0, object object_1, object[] object_2, Delegate293 delegate293_1)
	{
		return delegate293_1(object_0, object_1, object_2);
	}

	// Token: 0x06001C6A RID: 7274
	public extern Delegate293(object object_0, IntPtr intptr_0);

	// Token: 0x06001C6B RID: 7275 RVA: 0x00009E34 File Offset: 0x00008034
	static Delegate293()
	{
		Class15.smethod_14(typeof(Delegate293).TypeHandle);
	}

	// Token: 0x04000B05 RID: 2821
	internal static Delegate293 delegate293_0;
}
