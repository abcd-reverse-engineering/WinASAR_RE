using System;

// Token: 0x02000342 RID: 834
internal sealed class Delegate306 : MulticastDelegate
{
	// Token: 0x06001C9C RID: 7324
	public extern void Invoke(object object_0, string string_0, bool bool_0);

	// Token: 0x06001C9D RID: 7325 RVA: 0x00009F79 File Offset: 0x00008179
	public static void smethod_0(object object_0, string string_0, bool bool_0, Delegate306 delegate306_1)
	{
		delegate306_1(object_0, string_0, bool_0);
	}

	// Token: 0x06001C9E RID: 7326
	public extern Delegate306(object object_0, IntPtr intptr_0);

	// Token: 0x06001C9F RID: 7327 RVA: 0x00009F88 File Offset: 0x00008188
	static Delegate306()
	{
		Class15.smethod_14(typeof(Delegate306).TypeHandle);
	}

	// Token: 0x04000B12 RID: 2834
	internal static Delegate306 delegate306_0;
}
