using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPrac32
{
    internal class Program
    {
        class WrongNumberException : Exception
        {
            public WrongNumberException(string message) : base(message)
            {
                // 예외가 발생했을 때 특정한 작업을 할 코드를 여기에 적을 수 있다.
            }
        }

        static void Main(string[] args)
        {
            string[] array = { "가", "나" };
            Console.WriteLine("숫자를 입력해 주세요:");
            int input = 0;
            try
            {
                input = int.Parse(Console.ReadLine());

                if (input < 0 || input > 999)
                {
                    throw new WrongNumberException("0이상 999이하여야 합니다");
                }

                Console.WriteLine("입력한 위치의 값은 '" + array[input]
    + "' 입니다.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("숫자만 입력하세요!!");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("인덱스 범위를 벗어났습니다");
            }
            catch (WrongNumberException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("제대로 값을 입력하란 말이야!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally는 코드가 성공적이든 예외발생이든 무조건 실행!");
            }

        }
    }
}