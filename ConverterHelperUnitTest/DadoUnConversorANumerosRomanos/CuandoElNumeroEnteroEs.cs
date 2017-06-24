using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConverterHelper;

namespace ConverterHelperUnitTest.DadoUnNumeroEntero
{
	[TestClass]
	public class CuandoElNumeroEnteroEs
	{
		[TestMethod]
		public void Uno_Entonces_Retorna_I()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "I";

			//ACT
			string actual = sut.Convert(1);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Dos_Entonces_Retorna_II()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "II";

			//ACT
			string actual = sut.Convert(2);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Tres_Entonces_Retorna_III()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "III";

			//ACT
			string actual = sut.Convert(3);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Cuatro_Entonces_Retorna_IV()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "IV";

			//ACT
			string actual = sut.Convert(4);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Cinco_Entonces_Retorna_V()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "V";

			//ACT
			string actual = sut.Convert(5);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Seis_Entonces_Retorna_VI()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "VI";

			//ACT
			string actual = sut.Convert(6);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Siete_Entonces_Retorna_VII()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "VII";

			//ACT
			string actual = sut.Convert(7);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Ocho_Entonces_Retorna_VIII()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "VIII";

			//ACT
			string actual = sut.Convert(8);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Nueve_Entonces_Retorna_IX()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "IX";

			//ACT
			string actual = sut.Convert(9);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Diez_Entonces_Retorna_X()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "X";

			//ACT
			string actual = sut.Convert(10);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Once_Entonces_Retorna_XI()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "XI";

			//ACT
			string actual = sut.Convert(11);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Doce_Entonces_Retorna_XII()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "XII";

			//ACT
			string actual = sut.Convert(12);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Trece_Entonces_Retorna_XIII()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "XIII";

			//ACT
			string actual = sut.Convert(13);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Catorce_Entonces_Retorna_XIV()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "XIV";

			//ACT
			string actual = sut.Convert(14);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Quince_Entonces_Retorna_XV()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "XV";

			//ACT
			string actual = sut.Convert(15);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Dieciseis_Entonces_Retorna_XVI()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "XVI";

			//ACT
			string actual = sut.Convert(16);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Diecisiete_Entonces_Retorna_XVII()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "XVII";

			//ACT
			string actual = sut.Convert(17);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Dieciocho_Entonces_Retorna_XVIII()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "XVIII";

			//ACT
			string actual = sut.Convert(18);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Diecinueve_Entonces_Retorna_XIV()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "XIX";

			//ACT
			string actual = sut.Convert(19);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Veinte_Entonces_Retorna_XX()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "XX";

			//ACT
			string actual = sut.Convert(20);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Setenta_y_ocho_Entonces_Retorna_XX()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "LXXVIII";

			//ACT
			string actual = sut.Convert(78);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Trescientos_venticuatro_Entonces_Retorna_CCCXXIV()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "CCCXXIV";

			//ACT
			string actual = sut.Convert(324);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Ciento_Cinco_Entonces_Retorna_CV()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "CV";

			//ACT
			string actual = sut.Convert(105);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Mil_Ciento_Setenta_y_ocho_Entonces_Retorna_MCLXXVIII()
		{
			//ARRANGE
			Num2Rom sut = new Num2Rom();
			string expected = "MCLXXVIII";

			//ACT
			string actual = sut.Convert(1178);

			//ASSERT
			Assert.AreEqual(expected, actual);
		}

	}
}
