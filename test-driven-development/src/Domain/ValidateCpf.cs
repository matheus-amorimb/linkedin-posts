using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Domain
{
    public class ValidateCpf
    {
        private const int CpfLength = 11;
        private const int FactorFirstDigit = 10;
        private const int FactorSecondDigit = 11;
        
        
        public static string Execute(string cpf)
        {
            if (string.IsNullOrEmpty(cpf))
                throw new ArgumentException("CPF invalid.");

            string normalizedCpf = RemoveNonDigits(cpf);
            
            if (normalizedCpf.Length != CpfLength)
                throw new ArgumentException("CPF invalid.");

            CheckAllDigitsTheSame(normalizedCpf);

            var digit1 = CalculateDigit(normalizedCpf, FactorFirstDigit);
            var digit2 = CalculateDigit(normalizedCpf, FactorSecondDigit);

            if (!(digit1 == (normalizedCpf[9] - '0') && digit2 == (normalizedCpf[10] - '0')))
                throw new ArgumentException("CPF invalid.");

            return cpf;
        }

        private static string RemoveNonDigits(string cpf)
        {
            return Regex.Replace(cpf, @"\D", ""); // Remove todos os não dígitos
        }

        private static void CheckAllDigitsTheSame(string cpf)
        {
            if (cpf.All(c => c == cpf[0]))
                throw new ArgumentException("CPF invalid.");
        }

        private static int CalculateDigit(string cpf, int factor)
        {
            int total = 0;
            foreach (var digit in cpf.Take(9))
            {
                total += (digit - '0') * factor--;
            }

            var remainder = total % 11;
            return (remainder < 2) ? 0 : 11 - remainder;
        }
    }
}