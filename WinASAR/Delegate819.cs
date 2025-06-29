using System;

// Token: 0x02000543 RID: 1347
internal sealed class Delegate819 : MulticastDelegate
{
	// Token: 0x060024A0 RID: 9376
	public extern int Invoke(object object_0, char char_0);

	// Token: 0x060024A1 RID: 9377 RVA: 0x0000D2C8 File Offset: 0x0000B4C8
	public static int smethod_0(object object_0, char char_0, Delegate819 delegate819_1)
	{
		return delegate819_1(object_0, char_0);
	}

	// Token: 0x060024A2 RID: 9378
	public extern Delegate819(object object_0, IntPtr intptr_0);

	// Token: 0x060024A3 RID: 9379 RVA: 0x0000D2D5 File Offset: 0x0000B4D5
	static Delegate819()
	{
		Class15.smethod_14(typeof(Delegate819).TypeHandle);
	}

	// Token: 0x04000D13 RID: 3347
	internal static Delegate819 delegate819_0;
}
