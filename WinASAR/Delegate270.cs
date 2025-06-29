using System;

// Token: 0x0200031E RID: 798
internal sealed class Delegate270 : MulticastDelegate
{
	// Token: 0x06001C0C RID: 7180
	public extern object Invoke(object object_0);

	// Token: 0x06001C0D RID: 7181 RVA: 0x00009BD9 File Offset: 0x00007DD9
	public static object smethod_0(object object_0, Delegate270 delegate270_1)
	{
		return delegate270_1(object_0);
	}

	// Token: 0x06001C0E RID: 7182
	public extern Delegate270(object object_0, IntPtr intptr_0);

	// Token: 0x06001C0F RID: 7183 RVA: 0x00009BE4 File Offset: 0x00007DE4
	static Delegate270()
	{
		Class15.smethod_14(typeof(Delegate270).TypeHandle);
	}

	// Token: 0x04000AEE RID: 2798
	internal static Delegate270 delegate270_0;
}
