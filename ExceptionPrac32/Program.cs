using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionPrac32
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "가", "나" };
            Console.WriteLine("숫자를 입력해 주세요:");
            int input = 0;
            try
            {
                input = int.Parse(Console.ReadLine());
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
