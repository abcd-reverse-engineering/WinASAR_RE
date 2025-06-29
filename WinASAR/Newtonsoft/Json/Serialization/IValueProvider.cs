using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000FE RID: 254
	[NullableContext(1)]
	public interface IValueProvider
	{
		// Token: 0x060009B0 RID: 2480
		void SetValue(object target, [Nullable(2)] object value);

		// Token: 0x060009B1 RID: 2481
		[return: Nullable(2)]
		object GetValue(object target);
	}
}
