using System;
using System.Globalization;

// Token: 0x0200037F RID: 895
internal sealed class Delegate367 : MulticastDelegate
{
	// Token: 0x06001D90 RID: 7568
	public extern bool Invoke(string string_0, IFormatProvider iformatProvider_0, DateTimeStyles dateTimeStyles_0, ref DateTime dateTime_0);

	// Token: 0x06001D91 RID: 7569 RVA: 0x0000A5AD File Offset: 0x000087AD
	public static bool smethod_0(string string_0, IFormatProvider iformatProvider_0, DateTimeStyles dateTimeStyles_0, ref DateTime dateTime_0, Delegate367 delegate367_1)
	{
		return delegate367_1(string_0, iformatProvider_0, dateTimeStyles_0, ref dateTime_0);
	}

	// Token: 0x06001D92 RID: 7570
	public extern Delegate367(object object_0, IntPtr intptr_0);

	// Token: 0x06001D93 RID: 7571 RVA: 0x0000A5BE File Offset: 0x000087BE
	static Delegate367()
	{
		Class15.smethod_14(typeof(Delegate367).TypeHandle);
	}

	// Token: 0x04000B4F RID: 2895
	internal static Delegate367 delegate367_0;
}
