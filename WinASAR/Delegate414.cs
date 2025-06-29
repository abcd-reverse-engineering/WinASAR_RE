using System;

// Token: 0x020003AE RID: 942
internal sealed class Delegate414 : MulticastDelegate
{
	// Token: 0x06001E4C RID: 7756
	public extern object Invoke(object object_0, Type type_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001E4D RID: 7757 RVA: 0x0000AA6F File Offset: 0x00008C6F
	public static object smethod_0(object object_0, Type type_0, IFormatProvider iformatProvider_0, Delegate414 delegate414_1)
	{
		return delegate414_1(object_0, type_0, iformatProvider_0);
	}

	// Token: 0x06001E4E RID: 7758
	public extern Delegate414(object object_0, IntPtr intptr_0);

	// Token: 0x06001E4F RID: 7759 RVA: 0x0000AA7E File Offset: 0x00008C7E
	static Delegate414()
	{
		Class15.smethod_14(typeof(Delegate414).TypeHandle);
	}

	// Token: 0x04000B7E RID: 2942
	internal static Delegate414 delegate414_0;
}
