using System;

// Token: 0x02000345 RID: 837
internal sealed class Delegate309 : MulticastDelegate
{
	// Token: 0x06001CA8 RID: 7336
	public extern void Invoke(object object_0, string string_0, bool bool_0);

	// Token: 0x06001CA9 RID: 7337 RVA: 0x00009FC9 File Offset: 0x000081C9
	public static void smethod_0(object object_0, string string_0, bool bool_0, Delegate309 delegate309_1)
	{
		delegate309_1(object_0, string_0, bool_0);
	}

	// Token: 0x06001CAA RID: 7338
	public extern Delegate309(object object_0, IntPtr intptr_0);

	// Token: 0x06001CAB RID: 7339 RVA: 0x00009FD8 File Offset: 0x000081D8
	static Delegate309()
	{
		Class15.smethod_14(typeof(Delegate309).TypeHandle);
	}

	// Token: 0x04000B15 RID: 2837
	internal static Delegate309 delegate309_0;
}
