using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoTesteFST2;
using ProjetoTesteFSTI;

namespace TestMSTest
{
	[TesteClass]
	{
	public class UnitTest2
	{
		[TestMethod]
		public void SomarDoisNumeros()
		{
			//Abrabge - Preparação
			double pNum = 1;
			double SNum = 1;
			double rNum = 2;

			//Act - Ação
			var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Verificação
            Assert.AreEqual(sNum, resultado);
		}

		internal class TestMethodAttribute : Attribute
		{
		}
	}