using System;

// Token: 0x020002AD RID: 685
internal sealed class Delegate157 : MulticastDelegate
{
	// Token: 0x06001A48 RID: 6728
	public extern object Invoke(object object_0);

	// Token: 0x06001A49 RID: 6729 RVA: 0x000090BB File Offset: 0x000072BB
	public static object smethod_0(object object_0, Delegate157 delegate157_1)
	{
		return delegate157_1(object_0);
	}

	// Token: 0x06001A4A RID: 6730
	public extern Delegate157(object object_0, IntPtr intptr_0);

	// Token: 0x06001A4B RID: 6731 RVA: 0x000090C6 File Offset: 0x000072C6
	static Delegate157()
	{
		Class15.smethod_14(typeof(Delegate157).TypeHandle);
	}

	// Token: 0x04000A7D RID: 2685
	internal static Delegate157 delegate157_0;
}
