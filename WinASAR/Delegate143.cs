using System;

// Token: 0x0200029F RID: 671
internal sealed class Delegate143 : MulticastDelegate
{
	// Token: 0x06001A10 RID: 6672
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x06001A11 RID: 6673 RVA: 0x00008F55 File Offset: 0x00007155
	public static void smethod_0(object object_0, string string_0, Delegate143 delegate143_1)
	{
		delegate143_1(object_0, string_0);
	}

	// Token: 0x06001A12 RID: 6674
	public extern Delegate143(object object_0, IntPtr intptr_0);

	// Token: 0x06001A13 RID: 6675 RVA: 0x00008F62 File Offset: 0x00007162
	static Delegate143()
	{
		Class15.smethod_14(typeof(Delegate143).TypeHandle);
	}

	// Token: 0x04000A6F RID: 2671
	internal static Delegate143 delegate143_0;
}
