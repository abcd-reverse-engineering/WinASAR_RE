using System;

// Token: 0x020003DB RID: 987
internal sealed class Delegate459 : MulticastDelegate
{
	// Token: 0x06001F00 RID: 7936
	public extern bool Invoke(object object_0, Type type_0);

	// Token: 0x06001F01 RID: 7937 RVA: 0x0000AEFF File Offset: 0x000090FF
	public static bool smethod_0(object object_0, Type type_0, Delegate459 delegate459_1)
	{
		return delegate459_1(object_0, type_0);
	}

	// Token: 0x06001F02 RID: 7938
	public extern Delegate459(object object_0, IntPtr intptr_0);

	// Token: 0x06001F03 RID: 7939 RVA: 0x0000AF0C File Offset: 0x0000910C
	static Delegate459()
	{
		Class15.smethod_14(typeof(Delegate459).TypeHandle);
	}

	// Token: 0x04000BAB RID: 2987
	internal static Delegate459 delegate459_0;
}
