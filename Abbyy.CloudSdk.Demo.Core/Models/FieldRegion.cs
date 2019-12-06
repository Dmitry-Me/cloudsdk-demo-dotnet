using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abbyy.CloudSdk.Demo.Core.Models
{
	public class FieldRegion
	{
		public FieldRegion(int left, int top, int right, int bottom)
		{
			_left = left;
			_top = top;
			_right = right;
			_bottom = bottom;
		}

		public string Format()
		{
			string formatted = $"{_left},{_top},{_right},{_bottom}";
			return formatted;
		}

		private readonly int _left;
		private readonly int _top;
		private readonly int _right;
		private readonly int _bottom;
	}
}
