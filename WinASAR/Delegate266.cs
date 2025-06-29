using System;

// Token: 0x0200031A RID: 794
internal sealed class Delegate266 : MulticastDelegate
{
	// Token: 0x06001BFC RID: 7164
	public extern void Invoke(object object_0, object object_1);

	// Token: 0x06001BFD RID: 7165 RVA: 0x00009B73 File Offset: 0x00007D73
	public static void smethod_0(object object_0, object object_1, Delegate266 delegate266_1)
	{
		delegate266_1(object_0, object_1);
	}

	// Token: 0x06001BFE RID: 7166
	public extern Delegate266(object object_0, IntPtr intptr_0);

	// Token: 0x06001BFF RID: 7167 RVA: 0x00009B80 File Offset: 0x00007D80
	static Delegate266()
	{
		Class15.smethod_14(typeof(Delegate266).TypeHandle);
	}

	// Token: 0x04000AEA RID: 2794
	internal static Delegate266 delegate266_0;
}
