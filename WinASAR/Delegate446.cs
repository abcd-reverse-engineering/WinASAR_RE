using System;

// Token: 0x020003CE RID: 974
internal sealed class Delegate446 : MulticastDelegate
{
	// Token: 0x06001ECC RID: 7884
	public extern TimeSpan Invoke(string string_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001ECD RID: 7885 RVA: 0x0000ADA9 File Offset: 0x00008FA9
	public static TimeSpan smethod_0(string string_0, IFormatProvider iformatProvider_0, Delegate446 delegate446_1)
	{
		return delegate446_1(string_0, iformatProvider_0);
	}

	// Token: 0x06001ECE RID: 7886
	public extern Delegate446(object object_0, IntPtr intptr_0);

	// Token: 0x06001ECF RID: 7887 RVA: 0x0000ADB6 File Offset: 0x00008FB6
	static Delegate446()
	{
		Class15.smethod_14(typeof(Delegate446).TypeHandle);
	}

	// Token: 0x04000B9E RID: 2974
	internal static Delegate446 delegate446_0;
}
