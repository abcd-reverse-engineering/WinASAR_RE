using System;

// Token: 0x020002D8 RID: 728
internal sealed class Delegate200 : MulticastDelegate
{
	// Token: 0x06001AF4 RID: 6900
	public extern void Invoke(string string_0, string string_1);

	// Token: 0x06001AF5 RID: 6901 RVA: 0x000094F9 File Offset: 0x000076F9
	public static void smethod_0(string string_0, string string_1, Delegate200 delegate200_1)
	{
		delegate200_1(string_0, string_1);
	}

	// Token: 0x06001AF6 RID: 6902
	public extern Delegate200(object object_0, IntPtr intptr_0);

	// Token: 0x06001AF7 RID: 6903 RVA: 0x00009506 File Offset: 0x00007706
	static Delegate200()
	{
		Class15.smethod_14(typeof(Delegate200).TypeHandle);
	}

	// Token: 0x04000AA8 RID: 2728
	internal static Delegate200 delegate200_0;
}
