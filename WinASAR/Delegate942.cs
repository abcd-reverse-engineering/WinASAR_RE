using System;

// Token: 0x020005BE RID: 1470
internal sealed class Delegate942 : MulticastDelegate
{
	// Token: 0x0600268C RID: 9868
	public extern string Invoke(object object_0);

	// Token: 0x0600268D RID: 9869 RVA: 0x0000DED8 File Offset: 0x0000C0D8
	public static string smethod_0(object object_0, Delegate942 delegate942_1)
	{
		return delegate942_1(object_0);
	}

	// Token: 0x0600268E RID: 9870
	public extern Delegate942(object object_0, IntPtr intptr_0);

	// Token: 0x0600268F RID: 9871 RVA: 0x0000DEE3 File Offset: 0x0000C0E3
	static Delegate942()
	{
		Class15.smethod_14(typeof(Delegate942).TypeHandle);
	}

	// Token: 0x04000D8E RID: 3470
	internal static Delegate942 delegate942_0;
}
