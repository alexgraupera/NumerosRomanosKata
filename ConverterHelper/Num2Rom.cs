using ConverterHelper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterHelper
{

	public class Num2Rom
	{
		/*
		 * I = 1
		 * V = 5
		 * X = 10
		 * L = 50
		 * C = 100
		 * D = 500
		 * M = 1000
		*/

		public string Convert(int number)
		{

			string numeroRomano = string.Empty;
			int unitsValue = 0;
			int tensValue = 0;
			int hundredsValue = 0;
			int thousandsValue = 0;

			RomanScales romanScale = RomanScales.Units;

			string[] arrayUnits = new string[] { "I", "V", "X" };
			string[] arrayTens = new string[] { "X", "L", "C" };
			string[] arrayHundreds = new string[] { "C", "D", "M" };
			string[] arrayThousands = new string[] { "M", "", "" };

			romanScale = (number / 10 != 0) ? RomanScales.Tens : romanScale;
			romanScale = (number / 100 != 0) ? RomanScales.Hundreds : romanScale;
			romanScale = (number / 1000 != 0) && number < 4000 ? RomanScales.Thousands : romanScale;

			switch (romanScale)
			{
				case RomanScales.Units:
					unitsValue = number;
					numeroRomano = BuildRomanNumber(unitsValue, arrayUnits);
					break;
				case RomanScales.Tens:
					tensValue = number / 10;
					unitsValue = number % 10;
					numeroRomano = BuildRomanNumber(tensValue, arrayTens);
					numeroRomano += BuildRomanNumber(unitsValue, arrayUnits);
					break;
				case RomanScales.Hundreds:
					hundredsValue = number / 100;
					tensValue = (number % 100) / 10;
					unitsValue = number % 10;
					numeroRomano = BuildRomanNumber(hundredsValue, arrayHundreds);
					numeroRomano += BuildRomanNumber(tensValue, arrayTens);
					numeroRomano += BuildRomanNumber(unitsValue, arrayUnits);
					break;
				case RomanScales.Thousands:
					thousandsValue = number / 1000;
					hundredsValue = (number % 1000) / 100;
					tensValue = (number % 100) / 10;
					unitsValue = number % 10;
					numeroRomano = BuildRomanNumber(thousandsValue, arrayThousands);
					numeroRomano += BuildRomanNumber(hundredsValue, arrayHundreds);
					numeroRomano += BuildRomanNumber(tensValue, arrayTens);
					numeroRomano += BuildRomanNumber(unitsValue, arrayUnits);
					break;
			}

			return numeroRomano;
		}

		private string BuildRomanNumber(int number, string[] arrayScale)
		{
			string res = string.Empty;
			if(number == 4)
			{
				res = arrayScale[0] + arrayScale[1];
			}
			else if(number == 9)
			{
				res = arrayScale[0] + arrayScale[2];
			}
			else
			{
				if (number >= 5)
				{
					res = arrayScale[1];
				}
				int mod = number % 5;
				for (int i = 0; i < mod; i++)
				{
					res += arrayScale[0];
				}
			}
			return res;
		}
	}
}
