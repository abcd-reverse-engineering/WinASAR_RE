using System;

// Token: 0x02000336 RID: 822
internal sealed class Delegate294 : MulticastDelegate
{
	// Token: 0x06001C6C RID: 7276
	public extern string Invoke(object object_0);

	// Token: 0x06001C6D RID: 7277 RVA: 0x00009E41 File Offset: 0x00008041
	public static string smethod_0(object object_0, Delegate294 delegate294_1)
	{
		return delegate294_1(object_0);
	}

	// Token: 0x06001C6E RID: 7278
	public extern Delegate294(object object_0, IntPtr intptr_0);

	// Token: 0x06001C6F RID: 7279 RVA: 0x00009E4C File Offset: 0x0000804C
	static Delegate294()
	{
		Class15.smethod_14(typeof(Delegate294).TypeHandle);
	}

	// Token: 0x04000B06 RID: 2822
	internal static Delegate294 delegate294_0;
}
