using System;
using System.ComponentModel;
using System.Globalization;

// Token: 0x020003DC RID: 988
internal sealed class Delegate460 : MulticastDelegate
{
	// Token: 0x06001F04 RID: 7940
	public extern object Invoke(object object_0, ITypeDescriptorContext itypeDescriptorContext_0, CultureInfo cultureInfo_0, object object_1);

	// Token: 0x06001F05 RID: 7941 RVA: 0x0000AF19 File Offset: 0x00009119
	public static object smethod_0(object object_0, ITypeDescriptorContext itypeDescriptorContext_0, CultureInfo cultureInfo_0, object object_1, Delegate460 delegate460_1)
	{
		return delegate460_1(object_0, itypeDescriptorContext_0, cultureInfo_0, object_1);
	}

	// Token: 0x06001F06 RID: 7942
	public extern Delegate460(object object_0, IntPtr intptr_0);

	// Token: 0x06001F07 RID: 7943 RVA: 0x0000AF2A File Offset: 0x0000912A
	static Delegate460()
	{
		Class15.smethod_14(typeof(Delegate460).TypeHandle);
	}

	// Token: 0x04000BAC RID: 2988
	internal static Delegate460 delegate460_0;
}
