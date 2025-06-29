using System;

// Token: 0x0200031D RID: 797
internal sealed class Delegate269 : MulticastDelegate
{
	// Token: 0x06001C08 RID: 7176
	public extern void Invoke(object object_0);

	// Token: 0x06001C09 RID: 7177 RVA: 0x00009BC1 File Offset: 0x00007DC1
	public static void smethod_0(object object_0, Delegate269 delegate269_1)
	{
		delegate269_1(object_0);
	}

	// Token: 0x06001C0A RID: 7178
	public extern Delegate269(object object_0, IntPtr intptr_0);

	// Token: 0x06001C0B RID: 7179 RVA: 0x00009BCC File Offset: 0x00007DCC
	static Delegate269()
	{
		Class15.smethod_14(typeof(Delegate269).TypeHandle);
	}

	// Token: 0x04000AED RID: 2797
	internal static Delegate269 delegate269_0;
}
