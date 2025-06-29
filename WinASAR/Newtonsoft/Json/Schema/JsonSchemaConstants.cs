using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000130 RID: 304
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	internal static class JsonSchemaConstants
	{
		// Token: 0x06000CBC RID: 3260 RVA: 0x0006E1E0 File Offset: 0x0006C3E0
		static JsonSchemaConstants()
		{
			for (;;)
			{
				IL_0135:
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
				{
					goto IL_011D;
				}
				do
				{
					IL_0108:
					num = 2;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0);
				for (;;)
				{
					IL_011D:
					switch (num)
					{
					case 1:
						goto IL_0135;
					case 2:
						JsonSchemaConstants.JsonSchemaTypeMapping = new Dictionary<string, JsonSchemaType>
						{
							{
								Class15.smethod_17(1793894608 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a),
								JsonSchemaType.String
							},
							{
								Class15.smethod_17(432080991 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2),
								JsonSchemaType.Object
							},
							{
								Class15.smethod_17(1788669950 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1),
								JsonSchemaType.Integer
							},
							{
								Class15.smethod_17(432081021 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2),
								JsonSchemaType.Float
							},
							{
								Class15.smethod_17(1829614759 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae),
								JsonSchemaType.Null
							},
							{
								Class15.smethod_17(1387507924 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923),
								JsonSchemaType.Boolean
							},
							{
								Class15.smethod_17(1678050712 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a),
								JsonSchemaType.Array
							},
							{
								Class15.smethod_17(649931042 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff),
								JsonSchemaType.Any
							}
						};
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
						{
							return;
						}
						continue;
					case 3:
						return;
					}
					break;
				}
				goto IL_0108;
			}
		}

		// Token: 0x0400060A RID: 1546
		public const string TypePropertyName = "type";

		// Token: 0x0400060B RID: 1547
		public const string PropertiesPropertyName = "properties";

		// Token: 0x0400060C RID: 1548
		public const string ItemsPropertyName = "items";

		// Token: 0x0400060D RID: 1549
		public const string AdditionalItemsPropertyName = "additionalItems";

		// Token: 0x0400060E RID: 1550
		public const string RequiredPropertyName = "required";

		// Token: 0x0400060F RID: 1551
		public const string PatternPropertiesPropertyName = "patternProperties";

		// Token: 0x04000610 RID: 1552
		public const string AdditionalPropertiesPropertyName = "additionalProperties";

		// Token: 0x04000611 RID: 1553
		public const string RequiresPropertyName = "requires";

		// Token: 0x04000612 RID: 1554
		public const string MinimumPropertyName = "minimum";

		// Token: 0x04000613 RID: 1555
		public const string MaximumPropertyName = "maximum";

		// Token: 0x04000614 RID: 1556
		public const string ExclusiveMinimumPropertyName = "exclusiveMinimum";

		// Token: 0x04000615 RID: 1557
		public const string ExclusiveMaximumPropertyName = "exclusiveMaximum";

		// Token: 0x04000616 RID: 1558
		public const string MinimumItemsPropertyName = "minItems";

		// Token: 0x04000617 RID: 1559
		public const string MaximumItemsPropertyName = "maxItems";

		// Token: 0x04000618 RID: 1560
		public const string PatternPropertyName = "pattern";

		// Token: 0x04000619 RID: 1561
		public const string MaximumLengthPropertyName = "maxLength";

		// Token: 0x0400061A RID: 1562
		public const string MinimumLengthPropertyName = "minLength";

		// Token: 0x0400061B RID: 1563
		public const string EnumPropertyName = "enum";

		// Token: 0x0400061C RID: 1564
		public const string ReadOnlyPropertyName = "readonly";

		// Token: 0x0400061D RID: 1565
		public const string TitlePropertyName = "title";

		// Token: 0x0400061E RID: 1566
		public const string DescriptionPropertyName = "description";

		// Token: 0x0400061F RID: 1567
		public const string FormatPropertyName = "format";

		// Token: 0x04000620 RID: 1568
		public const string DefaultPropertyName = "default";

		// Token: 0x04000621 RID: 1569
		public const string TransientPropertyName = "transient";

		// Token: 0x04000622 RID: 1570
		public const string DivisibleByPropertyName = "divisibleBy";

		// Token: 0x04000623 RID: 1571
		public const string HiddenPropertyName = "hidden";

		// Token: 0x04000624 RID: 1572
		public const string DisallowPropertyName = "disallow";

		// Token: 0x04000625 RID: 1573
		public const string ExtendsPropertyName = "extends";

		// Token: 0x04000626 RID: 1574
		public const string IdPropertyName = "id";

		// Token: 0x04000627 RID: 1575
		public const string UniqueItemsPropertyName = "uniqueItems";

		// Token: 0x04000628 RID: 1576
		public const string OptionValuePropertyName = "value";

		// Token: 0x04000629 RID: 1577
		public const string OptionLabelPropertyName = "label";

		// Token: 0x0400062A RID: 1578
		public static readonly IDictionary<string, JsonSchemaType> JsonSchemaTypeMapping;
	}
}
