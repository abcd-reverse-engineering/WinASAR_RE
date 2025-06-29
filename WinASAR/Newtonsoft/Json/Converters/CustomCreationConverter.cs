using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200018E RID: 398
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class CustomCreationConverter<[Nullable(2)] T> : JsonConverter
	{
		// Token: 0x060011B1 RID: 4529 RVA: 0x000069FA File Offset: 0x00004BFA
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
			throw new NotSupportedException(Class15.smethod_17(1829588149 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae));
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x0008CBF4 File Offset: 0x0008ADF4
		[return: Nullable(2)]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			while (reader.TokenType != JsonToken.Null)
			{
				T t = this.Create(objectType);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
				{
					goto IL_0043;
				}
				IL_004F:
				switch (num)
				{
				case 0:
					goto IL_0043;
				case 1:
					goto IL_007D;
				case 2:
					break;
				case 3:
					goto IL_0085;
				case 4:
					IL_00A0:
					return null;
				case 5:
					continue;
				default:
					goto IL_0043;
				}
				IL_0020:
				serializer.Populate(reader, t);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
				{
					goto IL_007D;
				}
				goto IL_004F;
				IL_0043:
				if (t != null)
				{
					goto IL_0020;
				}
				goto IL_0085;
				IL_007D:
				return t;
				IL_0085:
				throw new JsonSerializationException(Class15.smethod_17(1396512522 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7));
			}
			goto IL_00A0;
		}

		// Token: 0x060011B3 RID: 4531
		public abstract T Create(Type objectType);

		// Token: 0x060011B4 RID: 4532 RVA: 0x00002C1B File Offset: 0x00000E1B
		public override bool CanConvert(Type objectType)
		{
			return typeof(T).IsAssignableFrom(objectType);
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x00003453 File Offset: 0x00001653
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x0008CCA4 File Offset: 0x0008AEA4
		protected CustomCreationConverter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x00006A16 File Offset: 0x00004C16
		internal static bool smethod_0()
		{
			return CustomCreationConverter<T>.object_0 == null;
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00006A20 File Offset: 0x00004C20
		internal static object smethod_1()
		{
			return CustomCreationConverter<T>.object_0;
		}

		// Token: 0x040007F0 RID: 2032
		private static object object_0;
	}
}
