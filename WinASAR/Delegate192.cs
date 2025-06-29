using System;

// Token: 0x020002D0 RID: 720
internal sealed class Delegate192 : MulticastDelegate
{
	// Token: 0x06001AD4 RID: 6868
	public extern bool Invoke(string string_0, string string_1);

	// Token: 0x06001AD5 RID: 6869 RVA: 0x00009431 File Offset: 0x00007631
	public static bool smethod_0(string string_0, string string_1, Delegate192 delegate192_1)
	{
		return delegate192_1(string_0, string_1);
	}

	// Token: 0x06001AD6 RID: 6870
	public extern Delegate192(object object_0, IntPtr intptr_0);

	// Token: 0x06001AD7 RID: 6871 RVA: 0x0000943E File Offset: 0x0000763E
	static Delegate192()
	{
		Class15.smethod_14(typeof(Delegate192).TypeHandle);
	}

	// Token: 0x04000AA0 RID: 2720
	internal static Delegate192 delegate192_0;
}
