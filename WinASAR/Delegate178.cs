using System;
using System.IO;

// Token: 0x020002C2 RID: 706
internal sealed class Delegate178 : MulticastDelegate
{
	// Token: 0x06001A9C RID: 6812
	public extern DirectoryInfo Invoke(object object_0);

	// Token: 0x06001A9D RID: 6813 RVA: 0x000092CD File Offset: 0x000074CD
	public static DirectoryInfo smethod_0(object object_0, Delegate178 delegate178_1)
	{
		return delegate178_1(object_0);
	}

	// Token: 0x06001A9E RID: 6814
	public extern Delegate178(object object_0, IntPtr intptr_0);

	// Token: 0x06001A9F RID: 6815 RVA: 0x000092D8 File Offset: 0x000074D8
	static Delegate178()
	{
		Class15.smethod_14(typeof(Delegate178).TypeHandle);
	}

	// Token: 0x04000A92 RID: 2706
	internal static Delegate178 delegate178_0;
}
