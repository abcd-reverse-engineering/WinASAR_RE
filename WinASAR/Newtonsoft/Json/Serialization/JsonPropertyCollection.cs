using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000111 RID: 273
	[Nullable(new byte[] { 0, 1, 1 })]
	[NullableContext(1)]
	public class JsonPropertyCollection : KeyedCollection<string, JsonProperty>
	{
		// Token: 0x06000AB3 RID: 2739 RVA: 0x0005B310 File Offset: 0x00059510
		public JsonPropertyCollection(Type type)
			: base(StringComparer.Ordinal)
		{
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(type, Class15.smethod_17(543240308 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
				{
					goto IL_0034;
				}
				IL_003D:
				switch (num)
				{
				case 0:
					goto IL_0034;
				case 1:
					return;
				case 2:
					continue;
				case 3:
					break;
				default:
					goto IL_0034;
				}
				IL_000F:
				this.list_0 = (List<JsonProperty>)base.Items;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
				{
					break;
				}
				goto IL_003D;
				IL_0034:
				this.type_0 = type;
				goto IL_000F;
			}
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00004F99 File Offset: 0x00003199
		protected override string GetKeyForItem(JsonProperty item)
		{
			return item.PropertyName;
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0005B3A4 File Offset: 0x000595A4
		public void AddProperty(JsonProperty property)
		{
			for (;;)
			{
				IL_0255:
				if (!base.Contains(property.PropertyName))
				{
					goto IL_019C;
				}
				goto IL_0247;
				int num;
				bool flag;
				for (;;)
				{
					IL_01D4:
					switch (num)
					{
					case 1:
						goto IL_0098;
					case 2:
						goto IL_015F;
					case 3:
					case 13:
						goto IL_00FB;
					case 4:
					case 12:
						goto IL_00CA;
					case 5:
						return;
					case 6:
						return;
					case 7:
						flag = false;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
						{
							goto Block_10;
						}
						continue;
					case 8:
						goto IL_0075;
					case 9:
						goto IL_004F;
					case 10:
						goto IL_0273;
					case 11:
						goto IL_0061;
					case 14:
						goto IL_0247;
					case 15:
						goto IL_0189;
					case 16:
						goto IL_0134;
					case 17:
						goto IL_0192;
					case 18:
						goto IL_019C;
					case 19:
						goto IL_0255;
					case 20:
						return;
					case 21:
						goto IL_002C;
					case 22:
						return;
					case 23:
						goto IL_00AC;
					case 24:
						goto IL_0195;
					case 25:
						goto IL_0029;
					}
					goto Block_11;
				}
				Block_10:
				goto IL_00FB;
				Block_11:
				goto IL_0127;
				IL_0247:
				if (property.Ignored)
				{
					return;
				}
				JsonProperty jsonProperty = base[property.PropertyName];
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
				{
					goto IL_0029;
				}
				goto IL_01D4;
				IL_002C:
				if (jsonProperty.Ignored)
				{
					goto IL_0189;
				}
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
				{
					goto IL_00CA;
				}
				goto IL_01D4;
				IL_0029:
				flag = true;
				goto IL_002C;
				IL_0075:
				if (!jsonProperty.DeclaringType.IsInterface())
				{
					goto IL_00FB;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0)
				{
					goto IL_0098;
				}
				goto IL_01D4;
				IL_0061:
				if (!property.DeclaringType.IsSubclassOf(jsonProperty.DeclaringType))
				{
					goto IL_0075;
				}
				goto IL_00AC;
				IL_004F:
				if (jsonProperty.DeclaringType != null)
				{
					goto IL_0061;
				}
				goto IL_0195;
				IL_00CA:
				if (property.DeclaringType != null)
				{
					goto IL_004F;
				}
				goto IL_0195;
				IL_00AC:
				base.Remove(jsonProperty);
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 == 0)
				{
					goto IL_00CA;
				}
				goto IL_01D4;
				IL_0098:
				if (property.DeclaringType.ImplementInterface(jsonProperty.DeclaringType))
				{
					goto IL_00AC;
				}
				num = 13;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
				{
					break;
				}
				goto IL_01D4;
				IL_00FB:
				if (jsonProperty.DeclaringType.IsSubclassOf(property.DeclaringType))
				{
					break;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
				{
					goto IL_0127;
				}
				goto IL_01D4;
				IL_015F:
				if (!this.type_0.ImplementInterface(property.DeclaringType))
				{
					goto IL_0195;
				}
				num = 20;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
				{
					break;
				}
				goto IL_01D4;
				IL_014B:
				if (this.type_0.ImplementInterface(jsonProperty.DeclaringType))
				{
					goto IL_015F;
				}
				goto IL_0195;
				IL_0134:
				if (!jsonProperty.DeclaringType.ImplementInterface(property.DeclaringType))
				{
					goto IL_014B;
				}
				break;
				IL_0127:
				if (property.DeclaringType.IsInterface())
				{
					goto IL_0134;
				}
				goto IL_014B;
				IL_019C:
				base.Add(property);
				num = 22;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
				{
					goto Block_9;
				}
				goto IL_01D4;
				IL_0195:
				if (!flag)
				{
					goto IL_019C;
				}
				goto IL_0273;
				IL_0192:
				flag = false;
				goto IL_0195;
				IL_0189:
				base.Remove(jsonProperty);
				goto IL_0192;
			}
			return;
			Block_9:
			return;
			IL_0273:
			throw new JsonSerializationException(Class15.smethod_17(926358253 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296).FormatWith(CultureInfo.InvariantCulture, property.PropertyName, this.type_0));
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0005B658 File Offset: 0x00059858
		[return: Nullable(2)]
		public JsonProperty GetClosestMatchProperty(string propertyName)
		{
			JsonProperty jsonProperty;
			for (;;)
			{
				IL_004F:
				jsonProperty = this.GetProperty(propertyName, StringComparison.Ordinal);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
				{
					goto IL_0021;
				}
				for (;;)
				{
					IL_0036:
					switch (num)
					{
					case 1:
						goto IL_004F;
					case 2:
						jsonProperty = this.GetProperty(propertyName, StringComparison.OrdinalIgnoreCase);
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
						{
							return jsonProperty;
						}
						continue;
					case 3:
						return jsonProperty;
					}
					break;
				}
				IL_0021:
				if (jsonProperty != null)
				{
					break;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
				{
					goto IL_0036;
				}
			}
			return jsonProperty;
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0005B6D8 File Offset: 0x000598D8
		private bool method_0(string string_0, [Nullable(2)] [NotNullWhen(true)] out JsonProperty item)
		{
			for (;;)
			{
				if (base.Dictionary == null)
				{
					goto IL_0003;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
				{
					break;
				}
				IL_0017:
				switch (num)
				{
				case 1:
					goto IL_004F;
				case 2:
					continue;
				case 3:
					return false;
				}
				IL_0003:
				item = null;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
				{
					goto IL_0017;
				}
				return false;
			}
			IL_004F:
			return base.Dictionary.TryGetValue(string_0, out item);
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0005B744 File Offset: 0x00059944
		[return: Nullable(2)]
		public JsonProperty GetProperty(string propertyName, StringComparison comparisonType)
		{
			IL_00BD:
			JsonProperty jsonProperty;
			while (comparisonType != StringComparison.Ordinal)
			{
				int num = 0;
				int num2 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
				{
					goto IL_0069;
				}
				for (;;)
				{
					IL_0089:
					JsonProperty jsonProperty2;
					switch (num2)
					{
					case 2:
						return jsonProperty;
					case 3:
						goto IL_00C4;
					case 4:
						goto IL_00BD;
					case 5:
					case 10:
						jsonProperty2 = this.list_0[num];
						num2 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
						{
							goto IL_003E;
						}
						continue;
					case 6:
						goto IL_003E;
					case 7:
						goto IL_00D5;
					case 8:
						goto IL_00D2;
					case 9:
						return jsonProperty2;
					}
					goto Block_4;
					IL_003E:
					if (string.Equals(propertyName, jsonProperty2.PropertyName, comparisonType))
					{
						return jsonProperty2;
					}
					num++;
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
					{
						goto IL_0069;
					}
				}
				return jsonProperty;
				Block_4:
				goto IL_0069;
				IL_00D2:
				return null;
				IL_0069:
				if (num < this.list_0.Count)
				{
					num2 = 10;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
					{
						goto IL_0089;
					}
				}
				IL_00D5:
				return null;
			}
			IL_00C4:
			if (this.method_0(propertyName, out jsonProperty))
			{
				return jsonProperty;
			}
			goto IL_00D2;
		}

		// Token: 0x04000583 RID: 1411
		private readonly Type type_0;

		// Token: 0x04000584 RID: 1412
		private readonly List<JsonProperty> list_0;
	}
}
