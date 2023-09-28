using System;

public class MeuObjeto {

  
  #region Private Attributes
  private double valorDelta, valorEquacaoSoma, valorEquacaoSubtracao;
  private bool calculouDelta = false, calculouEquacaoSoma = false, calculouEquacaoSubtracao = false;
  private double valorA, valorB, valorC;
  #endregion

  #region Public Attributes
  public double delta { 
    get { return calculouDelta ? valorDelta : CalculoDelta(); } 
    }
  public double equacaoSegundoGrauSoma { 
    get { return calculouEquacaoSoma ? valorEquacaoSoma : CalculoEquacaoSegundoGrauSoma(); } 
    }
  public double equacaoSegundoGrauSubtracao { 
    get { return calculouEquacaoSubtracao ? valorEquacaoSubtracao : CalculoEquacaoSegundoGrauSubtracao(); } 
    }
  #endregion
  

  #region Private Methods
  private bool InserirValor(string numeroDigitado, int index)
  {
    double valorConvertido;
      if (!double.TryParse(numeroDigitado, out valorConvertido))
      {
          throw new Exception("Você digitou um número inválido.");
          return false;
      }
      else
      {
        switch (index)
            {
            case 0: {
                    if (numeroDigitado == 0)
                      return false;
                    valorA = Double.Parse(valorDigitado);
                    break;
            }
                case 1:
                    valorB = Double.Parse(valorDigitado);
                    break;
                case 2:
                    valorC = Double.Parse(valorDigitado);
                    break;
                default:
                    break;
            }
          return true;
      }
  }
  private double CalculoDelta() {
      return valorDelta = (valorB * valorB) - 4 * valorA * valorC;
  }
  private double CalculoEquacaoSegundoGrauSoma() {
    return valorEquacaoSoma = (-valorB + Math.Sqrt(CalculoDelta())) / (2 * valorA);
  }
  private double CalculoEquacaoSegundoGrauSubtracao() {
    return valorEquacaoSubtracao = (-valorB - Math.Sqrt(CalculoDelta())) / (2 * valorA);
  }
  #endregion
}