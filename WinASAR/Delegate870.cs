using System;

// Token: 0x02000576 RID: 1398
internal sealed class Delegate870 : MulticastDelegate
{
	// Token: 0x0600256C RID: 9580
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x0600256D RID: 9581 RVA: 0x0000D7F0 File Offset: 0x0000B9F0
	public static void smethod_0(object object_0, string string_0, Delegate870 delegate870_1)
	{
		delegate870_1(object_0, string_0);
	}

	// Token: 0x0600256E RID: 9582
	public extern Delegate870(object object_0, IntPtr intptr_0);

	// Token: 0x0600256F RID: 9583 RVA: 0x0000D7FD File Offset: 0x0000B9FD
	static Delegate870()
	{
		Class15.smethod_14(typeof(Delegate870).TypeHandle);
	}

	// Token: 0x04000D46 RID: 3398
	internal static Delegate870 delegate870_0;
}
