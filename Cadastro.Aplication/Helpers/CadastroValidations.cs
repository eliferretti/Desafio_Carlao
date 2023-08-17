using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

namespace Cadastro.Aplication.Helpers
{
    //public class CadastroValidations
    //{
    //}
    public class CPFAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return true;

            string cpf = value.ToString();
            cpf = LimparCPF(cpf);

            if (cpf.Length != 11 || TemDigitosRepetidos(cpf))
            {
                return false;
            }

            int[] pesosPrimeiroDigito = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int primeiroDigito = CalcularDigitoVerificador(cpf, pesosPrimeiroDigito);

            int[] pesosSegundoDigito = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int segundoDigito = CalcularDigitoVerificador(cpf, pesosSegundoDigito);

            return cpf.EndsWith(primeiroDigito.ToString() + segundoDigito.ToString());
        }

        private static string LimparCPF(string cpf)
        {
            return new string(cpf.Where(char.IsDigit).ToArray());
        }

        private static bool TemDigitosRepetidos(string cpf)
        {
            char primeiroDigito = cpf[0];
            foreach (char c in cpf)
            {
                if (c != primeiroDigito)
                {
                    return false;
                }
            }
            return true;
        }

        private static int CalcularDigitoVerificador(string cpf, int[] pesos)
        {
            int soma = 0;
            for (int i = 0; i < pesos.Length; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * pesos[i];
            }

            int resto = soma % 11;
            return resto < 2 ? 0 : 11 - resto;
        }
    }

    public class SenhaComplexaAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;

            string senha = value.ToString();

            if (senha.Length < 8 || senha.Length > 20)
                return false;

            // Verifica se contém pelo menos uma letra maiúscula.
            if (!Regex.IsMatch(senha, "[A-Z]"))
                return false;

            // Verifica se contém pelo menos um caractere especial.
            if (!Regex.IsMatch(senha, "[!@#$%^&*(),.?\":{}|<>]"))
                return false;

            // Verifica se contém letras e números.
            if (!Regex.IsMatch(senha, "[a-zA-Z]") || !Regex.IsMatch(senha, "[0-9]"))
                return false;

            return true;
        }
    }
}
