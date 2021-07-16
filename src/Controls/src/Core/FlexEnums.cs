using System;
using System.ComponentModel;
using System.Globalization;
using Microsoft.Maui.Layouts;
using Flex = Microsoft.Maui.Layouts.Flex;

namespace Microsoft.Maui.Controls
{
	[Xaml.TypeConversion(typeof(FlexJustify))]
	public class FlexJustifyTypeConverter : StringTypeConverterBase
	{
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			var strValue = value?.ToString();

			if (strValue != null)
			{
				if (Enum.TryParse(strValue, true, out FlexJustify justify))
					return justify;
				if (strValue.Equals("flex-start", StringComparison.OrdinalIgnoreCase))
					return FlexJustify.Start;
				if (strValue.Equals("flex-end", StringComparison.OrdinalIgnoreCase))
					return FlexJustify.End;
				if (strValue.Equals("space-between", StringComparison.OrdinalIgnoreCase))
					return FlexJustify.SpaceBetween;
				if (strValue.Equals("space-around", StringComparison.OrdinalIgnoreCase))
					return FlexJustify.SpaceAround;
			}
			throw new InvalidOperationException(string.Format("Cannot convert \"{0}\" into {1}", strValue, typeof(FlexJustify)));
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (value is not FlexJustify fj)
				throw new NotSupportedException();
			return fj.ToString();
		}
	}

	[Xaml.TypeConversion(typeof(FlexDirection))]
	public class FlexDirectionTypeConverter : StringTypeConverterBase
	{
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			var strValue = value?.ToString();

			if (strValue != null)
			{
				if (Enum.TryParse(strValue, true, out FlexDirection aligncontent))
					return aligncontent;
				if (strValue.Equals("row-reverse", StringComparison.OrdinalIgnoreCase))
					return FlexDirection.RowReverse;
				if (strValue.Equals("column-reverse", StringComparison.OrdinalIgnoreCase))
					return FlexDirection.ColumnReverse;
			}
			throw new InvalidOperationException(string.Format("Cannot convert \"{0}\" into {1}", strValue, typeof(FlexDirection)));
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (value is not FlexDirection fd)
				throw new NotSupportedException();
			return fd.ToString();
		}
	}

	[Xaml.TypeConversion(typeof(FlexAlignContent))]
	public class FlexAlignContentTypeConverter : StringTypeConverterBase
	{
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			var strValue = value?.ToString();

			if (strValue != null)
			{
				if (Enum.TryParse(strValue, true, out FlexAlignContent aligncontent))
					return aligncontent;
				if (strValue.Equals("flex-start", StringComparison.OrdinalIgnoreCase))
					return FlexAlignContent.Start;
				if (strValue.Equals("flex-end", StringComparison.OrdinalIgnoreCase))
					return FlexAlignContent.End;
				if (strValue.Equals("space-between", StringComparison.OrdinalIgnoreCase))
					return FlexAlignContent.SpaceBetween;
				if (strValue.Equals("space-around", StringComparison.OrdinalIgnoreCase))
					return FlexAlignContent.SpaceAround;
			}
			throw new InvalidOperationException(string.Format("Cannot convert \"{0}\" into {1}", strValue, typeof(FlexAlignContent)));
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (value is not FlexAlignContent fac)
				throw new NotSupportedException();
			return fac.ToString();
		}
	}

	[Xaml.TypeConversion(typeof(FlexAlignItems))]
	public class FlexAlignItemsTypeConverter : StringTypeConverterBase
	{
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			var strValue = value?.ToString();

			if (strValue != null)
			{
				if (Enum.TryParse(strValue, true, out FlexAlignItems alignitems))
					return alignitems;
				if (strValue.Equals("flex-start", StringComparison.OrdinalIgnoreCase))
					return FlexAlignItems.Start;
				if (strValue.Equals("flex-end", StringComparison.OrdinalIgnoreCase))
					return FlexAlignItems.End;
			}
			throw new InvalidOperationException(string.Format("Cannot convert \"{0}\" into {1}", strValue, typeof(FlexAlignItems)));
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (value is not FlexAlignItems fai)
				throw new NotSupportedException();
			return fai.ToString();
		}
	}

	[Xaml.TypeConversion(typeof(FlexAlignSelf))]
	public class FlexAlignSelfTypeConverter : StringTypeConverterBase
	{
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			var strValue = value?.ToString();

			if (strValue != null)
			{
				if (Enum.TryParse(strValue, true, out FlexAlignSelf alignself))
					return alignself;
				if (strValue.Equals("flex-start", StringComparison.OrdinalIgnoreCase))
					return FlexAlignSelf.Start;
				if (strValue.Equals("flex-end", StringComparison.OrdinalIgnoreCase))
					return FlexAlignSelf.End;
			}
			throw new InvalidOperationException(string.Format("Cannot convert \"{0}\" into {1}", strValue, typeof(FlexAlignSelf)));
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (value is not FlexAlignSelf fes)
				throw new NotSupportedException();
			return fes.ToString();
		}
	}

	[Xaml.TypeConversion(typeof(FlexWrap))]
	public class FlexWrapTypeConverter : StringTypeConverterBase
	{
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			var strValue = value?.ToString();

			if (strValue != null)
			{
				if (Enum.TryParse(strValue, true, out FlexWrap wrap))
					return wrap;
				if (strValue.Equals("wrap-reverse", StringComparison.OrdinalIgnoreCase))
					return FlexWrap.Reverse;
			}
			throw new InvalidOperationException(string.Format("Cannot convert \"{0}\" into {1}", strValue, typeof(FlexWrap)));
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (value is not FlexWrap fw)
				throw new NotSupportedException();
			return fw.ToString();
		}
	}

	[Xaml.TypeConversion(typeof(FlexBasis))]
	public class FlexBasisTypeConverter : StringTypeConverterBase
	{
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			var strValue = value?.ToString();
			if (strValue != null)
			{
				if (strValue.Equals("auto", StringComparison.OrdinalIgnoreCase))
					return FlexBasis.Auto;
				value = strValue.Trim();
				if (strValue.EndsWith("%", StringComparison.OrdinalIgnoreCase) && float.TryParse(strValue.Substring(0, strValue.Length - 1), NumberStyles.Number, CultureInfo.InvariantCulture, out float relflex))
					return new FlexBasis(relflex / 100, isRelative: true);
				if (float.TryParse(strValue, NumberStyles.Number, CultureInfo.InvariantCulture, out float flex))
					return new FlexBasis(flex);
			}
			throw new InvalidOperationException(string.Format("Cannot convert \"{0}\" into {1}", strValue, typeof(FlexBasis)));
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (value is not FlexBasis basis)
				throw new NotSupportedException();
			if (basis.IsAuto)
				return "auto";
			if (basis.IsRelative)
				return $"{(basis.Length * 100).ToString(CultureInfo.InvariantCulture)}%";
			return $"{basis.Length.ToString(CultureInfo.InvariantCulture)}";
		}
	}
}