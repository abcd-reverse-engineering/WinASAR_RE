using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200019D RID: 413
	[Nullable(0)]
	[NullableContext(1)]
	public class StringEnumConverter : JsonConverter
	{
		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x00090B50 File Offset: 0x0008ED50
		// (set) Token: 0x06001224 RID: 4644 RVA: 0x00090B98 File Offset: 0x0008ED98
		[Obsolete("StringEnumConverter.CamelCaseText is obsolete. Set StringEnumConverter.NamingStrategy with CamelCaseNamingStrategy instead.")]
		public bool CamelCaseText
		{
			get
			{
				while (!(this.NamingStrategy is CamelCaseNamingStrategy))
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					return false;
				}
				return true;
			}
			set
			{
				for (;;)
				{
					if (value)
					{
						goto IL_0047;
					}
					int num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
					{
						goto Block_3;
					}
					IL_001F:
					switch (num)
					{
					case 1:
						IL_0047:
						if (this.NamingStrategy is CamelCaseNamingStrategy)
						{
							goto Block_2;
						}
						this.NamingStrategy = new CamelCaseNamingStrategy();
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
						{
							goto IL_001F;
						}
						break;
					case 2:
						goto IL_0083;
					case 3:
						return;
					case 4:
						return;
					case 5:
						return;
					case 6:
						goto IL_0076;
					case 7:
						continue;
					}
					break;
				}
				return;
				Block_2:
				return;
				Block_3:
				return;
				IL_0076:
				if (!(this.NamingStrategy is CamelCaseNamingStrategy))
				{
					return;
				}
				IL_0083:
				this.NamingStrategy = null;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x00006AD9 File Offset: 0x00004CD9
		// (set) Token: 0x06001226 RID: 4646 RVA: 0x00090C34 File Offset: 0x0008EE34
		[Nullable(2)]
		public NamingStrategy NamingStrategy
		{
			[NullableContext(2)]
			[CompilerGenerated]
			get
			{
				return this.namingStrategy_0;
			}
			[NullableContext(2)]
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.namingStrategy_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
						break;
					}
					break;
				}
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x00006AE1 File Offset: 0x00004CE1
		// (set) Token: 0x06001228 RID: 4648 RVA: 0x00090C6C File Offset: 0x0008EE6C
		public bool AllowIntegerValues
		{
			[CompilerGenerated]
			get
			{
				return this.bool_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
						break;
					}
					break;
				}
			}
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x00090CA4 File Offset: 0x0008EEA4
		public StringEnumConverter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x00090CE0 File Offset: 0x0008EEE0
		[Obsolete("StringEnumConverter(bool) is obsolete. Create a converter with StringEnumConverter(NamingStrategy, bool) instead.")]
		public StringEnumConverter(bool camelCaseText)
		{
			int num = 2;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
			{
				goto IL_0052;
			}
			IL_0021:
			if (!camelCaseText)
			{
				return;
			}
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
			{
				goto IL_0052;
			}
			IL_0036:
			this.NamingStrategy = new CamelCaseNamingStrategy();
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
			{
				return;
			}
			IL_0052:
			switch (num)
			{
			case 1:
				goto IL_0036;
			case 2:
				goto IL_0021;
			}
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x00090D54 File Offset: 0x0008EF54
		public StringEnumConverter(NamingStrategy namingStrategy, bool allowIntegerValues = true)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
			{
				goto IL_003E;
			}
			goto IL_0047;
			IL_0023:
			this.AllowIntegerValues = allowIntegerValues;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
			{
				return;
			}
			goto IL_0047;
			IL_003E:
			this.NamingStrategy = namingStrategy;
			goto IL_0023;
			IL_0047:
			switch (num)
			{
			case 1:
				goto IL_003E;
			case 2:
				goto IL_0023;
			}
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x00090DC0 File Offset: 0x0008EFC0
		public StringEnumConverter(Type namingStrategyType)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
			{
				goto IL_0044;
			}
			goto IL_0073;
			IL_0023:
			this.NamingStrategy = JsonTypeReflector.CreateNamingStrategyInstance(namingStrategyType, null);
			num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
			{
				return;
			}
			goto IL_0073;
			IL_0044:
			ValidationUtils.ArgumentNotNull(namingStrategyType, Class15.smethod_17(1471405601 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e));
			num = 2;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
			{
				goto IL_0023;
			}
			IL_0073:
			switch (num)
			{
			case 0:
				goto IL_0044;
			case 1:
				break;
			case 2:
				goto IL_0023;
			default:
				goto IL_0044;
			}
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x00090E58 File Offset: 0x0008F058
		public StringEnumConverter(Type namingStrategyType, object[] namingStrategyParameters)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
			{
				goto IL_004D;
			}
			IL_0021:
			ValidationUtils.ArgumentNotNull(namingStrategyType, Class15.smethod_17(124784390 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719));
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
			{
				goto IL_0062;
			}
			IL_004D:
			switch (num)
			{
			case 1:
				goto IL_0021;
			case 2:
				return;
			}
			IL_0062:
			this.NamingStrategy = JsonTypeReflector.CreateNamingStrategyInstance(namingStrategyType, namingStrategyParameters);
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x00090ED4 File Offset: 0x0008F0D4
		public StringEnumConverter(Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
			{
				goto IL_005D;
			}
			goto IL_007A;
			IL_0023:
			this.NamingStrategy = JsonTypeReflector.CreateNamingStrategyInstance(namingStrategyType, namingStrategyParameters);
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
			{
				goto IL_007A;
			}
			IL_0042:
			this.AllowIntegerValues = allowIntegerValues;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
			{
				return;
			}
			goto IL_007A;
			IL_005D:
			ValidationUtils.ArgumentNotNull(namingStrategyType, Class15.smethod_17(1396518450 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7));
			goto IL_0023;
			IL_007A:
			switch (num)
			{
			case 0:
				goto IL_0042;
			case 1:
				goto IL_005D;
			case 2:
				break;
			case 3:
				goto IL_0023;
			default:
				goto IL_0042;
			}
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x00090F74 File Offset: 0x0008F174
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
			Enum @enum;
			for (;;)
			{
				if (value != null)
				{
					goto IL_0039;
				}
				goto IL_006C;
				IL_0043:
				int num;
				switch (num)
				{
				default:
					IL_006C:
					writer.WriteNull();
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
					{
						return;
					}
					goto IL_0043;
				case 1:
					return;
				case 2:
					IL_0039:
					@enum = (Enum)value;
					break;
				case 3:
					continue;
				case 4:
					return;
				case 5:
					goto IL_0090;
				case 6:
					return;
				case 7:
					goto IL_0098;
				case 8:
					break;
				}
				string text;
				if (!EnumUtils.TryToString(@enum.GetType(), value, this.NamingStrategy, out text))
				{
					goto IL_0090;
				}
				writer.WriteValue(text);
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
				{
					break;
				}
				goto IL_0043;
			}
			return;
			IL_0090:
			if (this.AllowIntegerValues)
			{
				writer.WriteValue(value);
				return;
			}
			IL_0098:
			throw JsonSerializationException.Create(null, writer.ContainerPath, Class15.smethod_17(538798033 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa).FormatWith(CultureInfo.InvariantCulture, @enum.ToString(Class15.smethod_17(1603801964 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c))), null);
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x0009106C File Offset: 0x0008F26C
		[return: Nullable(2)]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			for (;;)
			{
				int num;
				bool flag;
				if (reader.TokenType == JsonToken.Null)
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
					{
						break;
					}
				}
				else
				{
					flag = ReflectionUtils.IsNullableType(objectType);
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
					{
						goto IL_001D;
					}
				}
				IL_0032:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0094;
				case 3:
					goto IL_0097;
				case 4:
					goto IL_007E;
				case 5:
					IL_001D:
					if (!flag)
					{
						goto IL_0094;
					}
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
					{
						goto IL_0032;
					}
					break;
				case 6:
					goto IL_021C;
				case 7:
					goto IL_0243;
				}
				break;
			}
			goto IL_0087;
			IL_007E:
			Type type = Nullable.GetUnderlyingType(objectType);
			goto IL_0095;
			IL_0087:
			if (ReflectionUtils.IsNullableType(objectType))
			{
				return null;
			}
			goto IL_021C;
			IL_0094:
			type = objectType;
			IL_0095:
			Type type2 = type;
			IL_0097:
			try
			{
				if (reader.TokenType != JsonToken.String)
				{
					goto IL_0155;
				}
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
				{
					goto IL_00D3;
				}
				goto IL_00E6;
				IL_00B9:
				string text = null;
				IL_00BA:
				string text2 = text;
				num2 = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
				{
					goto IL_0168;
				}
				goto IL_00E6;
				IL_00D3:
				object value = reader.Value;
				if (value != null)
				{
					text = value.ToString();
					goto IL_00BA;
				}
				goto IL_00B9;
				IL_00E6:
				switch (num2)
				{
				case 0:
					goto IL_0162;
				case 1:
					goto IL_00D3;
				case 2:
					goto IL_0177;
				case 3:
					goto IL_0196;
				case 4:
				{
					IL_0168:
					bool flag;
					if (StringUtils.IsNullOrEmpty(text2) && flag)
					{
						goto IL_0174;
					}
					goto IL_017C;
				}
				case 5:
					goto IL_0174;
				case 6:
					goto IL_014A;
				case 7:
					IL_0155:
					if (reader.TokenType == JsonToken.Integer)
					{
						goto IL_014A;
					}
					goto IL_01C7;
				case 8:
					goto IL_01C7;
				case 9:
					break;
				case 10:
					goto IL_00B9;
				case 11:
					goto IL_017C;
				case 12:
					goto IL_019B;
				default:
					goto IL_0162;
				}
				IL_0122:
				object obj = ConvertUtils.ConvertOrCast(reader.Value, CultureInfo.InvariantCulture, type2);
				num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
				{
					goto IL_0162;
				}
				goto IL_00E6;
				IL_014A:
				if (this.AllowIntegerValues)
				{
					goto IL_0122;
				}
				goto IL_019B;
				IL_0162:
				return obj;
				IL_0174:
				obj = null;
				IL_0177:
				return obj;
				IL_017C:
				obj = EnumUtils.ParseEnum(type2, this.NamingStrategy, text2, !this.AllowIntegerValues);
				IL_0196:
				return obj;
				IL_019B:
				throw JsonSerializationException.Create(reader, Class15.smethod_17(1793914674 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a).FormatWith(CultureInfo.InvariantCulture, reader.Value));
				IL_01C7:
				goto IL_0243;
			}
			catch (Exception ex)
			{
				int num3 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0)
				{
					switch (num3)
					{
					}
				}
				throw JsonSerializationException.Create(reader, Class15.smethod_17(41483727 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d).FormatWith(CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(reader.Value), objectType), ex);
			}
			IL_021C:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(635792679 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2).FormatWith(CultureInfo.InvariantCulture, objectType));
			IL_0243:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(1424597378 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf).FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x0009130C File Offset: 0x0008F50C
		public override bool CanConvert(Type objectType)
		{
			Type type;
			while (ReflectionUtils.IsNullableType(objectType))
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_003C;
					}
				}
				type = Nullable.GetUnderlyingType(objectType);
				IL_003D:
				return type.IsEnum();
			}
			IL_003C:
			type = objectType;
			goto IL_003D;
		}

		// Token: 0x0400080F RID: 2063
		[CompilerGenerated]
		[Nullable(2)]
		private NamingStrategy namingStrategy_0;

		// Token: 0x04000810 RID: 2064
		[CompilerGenerated]
		private bool bool_0 = true;
	}
}
