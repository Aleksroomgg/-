using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практическая_работа_1.Core
{
    internal class ProverkaType
    {
        public T Type<T>(string s) where T : struct
        {
            while (true)
            {
                Console.Write(s);
                var input = Console.ReadLine();
                if (ConvertType<T>(input.Replace(".", ","), out var result))
                {
                    return result;
                }
                else
                {

                }
            }
        }


        private bool ConvertType<T>(string input, out T result) where T : struct
        {
            try
            {
                result = (T)Convert.ChangeType(input, typeof(T));
                return true;
            }
            catch
            {
                result = default;
                return false;
            }
        }
    }
}
