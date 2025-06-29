using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000054 RID: 84
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class JsonConverter<[Nullable(2)] T> : JsonConverter
	{
		// Token: 0x06000298 RID: 664 RVA: 0x000283B4 File Offset: 0x000265B4
		public sealed override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
			for (;;)
			{
				if (value == null)
				{
					goto IL_005B;
				}
				bool flag = value is T;
				IL_006A:
				if (flag)
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
					{
						goto IL_0020;
					}
					IL_003F:
					switch (num)
					{
					case 1:
						goto IL_0078;
					case 2:
						goto IL_005B;
					case 3:
						continue;
					case 4:
						IL_0020:
						this.WriteJson(writer, (T)((object)value), serializer);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
						{
							goto IL_003F;
						}
						break;
					}
					break;
				}
				goto IL_0078;
				IL_005B:
				flag = ReflectionUtils.IsNullable(typeof(T));
				goto IL_006A;
			}
			return;
			IL_0078:
			throw new JsonSerializationException(Class15.smethod_17(124833502 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719).FormatWith(CultureInfo.InvariantCulture, typeof(T)));
		}

		// Token: 0x06000299 RID: 665
		public abstract void WriteJson(JsonWriter writer, [Nullable(2)] T value, JsonSerializer serializer);

		// Token: 0x0600029A RID: 666 RVA: 0x00028468 File Offset: 0x00026668
		[return: Nullable(2)]
		public sealed override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			bool flag;
			for (;;)
			{
				flag = existingValue == null;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
				{
					goto IL_0022;
				}
				IL_0037:
				switch (num)
				{
				case 0:
					goto IL_0022;
				case 1:
					continue;
				case 2:
					goto IL_00A0;
				case 3:
					goto IL_0071;
				case 4:
					break;
				default:
					goto IL_0022;
				}
				IL_0003:
				if (existingValue is T)
				{
					goto IL_00A0;
				}
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a == 0)
				{
					break;
				}
				goto IL_0037;
				IL_0022:
				if (!flag)
				{
					goto IL_0003;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
				{
					goto IL_0037;
				}
				goto IL_006D;
			}
			goto IL_0071;
			IL_006D:
			goto IL_00A0;
			IL_0071:
			throw new JsonSerializationException(Class15.smethod_17(486538624 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c).FormatWith(CultureInfo.InvariantCulture, typeof(T)));
			IL_00A0:
			return this.ReadJson(reader, objectType, flag ? default(T) : ((T)((object)existingValue)), !flag, serializer);
		}

		// Token: 0x0600029B RID: 667
		[return: Nullable(2)]
		public abstract T ReadJson(JsonReader reader, Type objectType, [Nullable(2)] T existingValue, bool hasExistingValue, JsonSerializer serializer);

		// Token: 0x0600029C RID: 668 RVA: 0x00002C1B File Offset: 0x00000E1B
		public sealed override bool CanConvert(Type objectType)
		{
			return typeof(T).IsAssignableFrom(objectType);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00028540 File Offset: 0x00026740
		protected JsonConverter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002C2D File Offset: 0x00000E2D
		internal static bool smethod_0()
		{
			return JsonConverter<T>.object_0 == null;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002C37 File Offset: 0x00000E37
		internal static object smethod_1()
		{
			return JsonConverter<T>.object_0;
		}

		// Token: 0x040001E9 RID: 489
		private static object object_0;
	}
}
