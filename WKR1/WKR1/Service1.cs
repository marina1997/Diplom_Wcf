using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Numerics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics;
using Lachesis.QuantumComputing;

namespace WKR1
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service1 : IService1
    {

        public int deutschStart(string array)                                               // Алгоритм Дойча
        {
            int count = 1;
            Matrix<Complex> matrixOracle = Matrix<Complex>.Build.Sparse(4, 4);              // Создание разреженной матрицы. Матрица для Оракула, заполняется пользователем
            for (int row = 0; row < 4; row++)                                               // Цикл в котором заполняется Оракул
            {
                for (int column = 0; column < 4; column++)
                {
                    matrixOracle.At(row, column, Convert.ToInt32(array[count-1]));
                    count++;
                }
            }
            Deutsch deutsch = new Deutsch(new Random());                                      // , new TextBox()
            int i = deutsch.Run(matrixOracle);
            return i;
        }

        public string groverStart(string arrayStr, int numberIterations)              // Алгоритм Гровера
        {
            string answer_mas;                                              // Хранятся все ответы
            int[] arrayInt = new int[8];
            for (int count = 0; count < 8; count++)
            {
                arrayInt[count] = Convert.ToInt32(arrayStr[count]);
                arrayInt[count] = arrayInt[count] - 48;
            }
            Grover grover = new Grover(new Random());
            answer_mas = grover.Run(numberIterations, arrayInt);
            return answer_mas;
        }
        public int[] shorStart(int numberToFactor, int registerLength)
        {
            //WSHttpBinding binding = new WSHttpBinding();
            //binding.OpenTimeout = new TimeSpan(0, 10, 0);
            //binding.CloseTimeout = new TimeSpan(0, 10, 0);
            //binding.SendTimeout = new TimeSpan(1, 0, 0);
            //binding.ReceiveTimeout = new TimeSpan(2, 0, 0);
            Shor shor = new Shor(new Random());
             int[] a=new int[2];
             a=shor.Run(numberToFactor, registerLength);
             return a;
        }
        public string simonStart(int[] array)                                               // Алгоритм Саймона
        {
            int count = 1;
            Matrix<Complex> matrixOracle = Matrix<Complex>.Build.Sparse(16, 16);             // Создание разреженной матрицы. Матрица для Оракула, заполняется пользователем
            for (int row = 0; row < 16; row++)                                                // Цикл в котором заполняется Оракул
            {
                for (int column = 0; column < 16; column++)
                {
                    if (array[count - 1] == 0) matrixOracle.At(row, column, 0);
                    else matrixOracle.At(row, column, 1);
                    count++;
                }
            }
            string answer_mas;                                                                 // Хранятся все ответы
            Simon simon = new Simon(new Random());
            answer_mas = simon.Run(matrixOracle);
            return answer_mas;
        }
    }

    class Deutsch                                                                             // Квантовый алгоритм Дойча
    {
        protected Random Random;
        public Deutsch(Random random)                                                          //, TextBox textBox
        {
            this.Random = random;                                                              // this.textBox1 = textBox;                                                                                     
        }
        public int Run(Matrix<Complex> matrixOracle)
        {
            int registerLength = 1;                                                            // Кол-во кубитов. квантовый регистр это совокупность некоторого числа кубитов 
            // Подготовка начально состояния
            QuantumRegister inputRegister = new QuantumRegister(0, registerLength);            // Входной регистр
            QuantumRegister outputRegister = new QuantumRegister(1, registerLength);           // Выходной регистр 
            QuantumRegister fullRegister = new QuantumRegister(inputRegister, outputRegister); // Полный регистр (получается тензорным произведением)

            fullRegister = QuantumGate.HadamardGateOfLength(2) * fullRegister;                 // Преобразование Адамара. Первый шаг

            QuantumGate GateOracle = new QuantumGate(matrixOracle);                            // Проектирование оракула. Второй шаг. Получаем гейт (на основе matrixOracle)

            fullRegister = GateOracle * fullRegister;                                          // Применение Оракула к кубитам. Второй шаг
            fullRegister = QuantumGate.HadamardGateOfLength(2) * fullRegister;                 // Преобразование Адамара. Третий шаг


            fullRegister.Collapse(this.Random);                                                // Измерение (наблюление) первого регистра. Четвертый шаг
            int inputRegesterValue = fullRegister.GetValue(0, registerLength);                 // Полечение первого регистра. Четвертый шаг

            return inputRegesterValue;
        }
    }

    class Grover                                                                                       // Алгоритм Гровера
    {
        protected Random Random;

        public Grover(Random random)
        {
            this.Random = random;
        }

        public string Run(int numberIterations, int[] array)
        {
            int registerLength = 3;                                                                     // Кол-во кубитов.
            QuantumRegister fullRegister = new QuantumRegister(0, registerLength);                      // Полный регистр
            fullRegister = QuantumGate.HadamardGateOfLength(registerLength) * fullRegister;             // Преобразование Адамара. Первый шаг
            Matrix<Complex> matrixOracle = MatrixOracle(registerLength, array);                         // Проектирование оракула. Второй шаг
            QuantumGate GateOracle = new QuantumGate(matrixOracle);                                     // Получаем гейт (на основе matrixOracle)


            Matrix<Complex> matrixPhaseInverse = PhaseInverse(registerLength);                          // Проектирование матрицы оператора диффузии (условные сдвиг фазы) 
            QuantumGate GatePhaseInverse = new QuantumGate(matrixPhaseInverse);                         // Гейт условного сдвига фазы
            for (int count = numberIterations; count > 0; count--)                                      // Применение итерации Гровера. Третий шаг
            {
                fullRegister = GateOracle * fullRegister;
                //fullRegister = QuantumGate.HadamardGateOfLength(registerLength) * fullRegister;
                fullRegister = GatePhaseInverse * fullRegister;
                //fullRegister = QuantumGate.HadamardGateOfLength(registerLength) * fullRegister;
            }

            fullRegister.Collapse(this.Random);                                                         // Измерение (наблюление). Четвертый шаг
            int RegisterValue = fullRegister.GetValue(0, registerLength);                               // Измерение
            string BinaryRegisterValue = HexToBin(RegisterValue, registerLength);                       // Перевод из 10 в 2 систему
            return (BinaryRegisterValue);
            ;

        }

        protected static Matrix<Complex> MatrixOracle(int registerLegth, int[] array)                     // Метод для построения Оракула
        {
            Matrix<Complex> matrixOracle = Matrix<Complex>.Build.Sparse(array.Length, array.Length);      // Создание разреженной матрицы
            for (int RowColumn = 0; RowColumn < array.Length; RowColumn++)                                // Цикл для построений оракула
            {
                if (array[RowColumn] == 0) matrixOracle.At(RowColumn, RowColumn, 1);
                else matrixOracle.At(RowColumn, RowColumn, -1);
            }
            return matrixOracle;
        }
        protected static Matrix<Complex> PhaseInverse(int registerLegth)                                  // Метода для построения оператора условного сдвига фазы
        {
            int matrixSize = 1 << registerLegth;                                                          // Определение размеар оракула(матрицы)
            Complex n = 2 * 1 / Math.Pow(2, registerLegth);
            Matrix<Complex> matrixPhaseInverse = Matrix<Complex>.Build.Dense(matrixSize, matrixSize, n);  // Создание разреженной матрицы
            n = n - 1;
            for (int RowColumn = 0; RowColumn < matrixSize; RowColumn++)
            {
                matrixPhaseInverse.At(RowColumn, RowColumn, n);
            }
            return matrixPhaseInverse;
        }


        private string HexToBin(int a, int n)                                                             //Перевод из 10 в 2 систему и дополнение нулей. n количество кубитов
        {
            string original = Convert.ToString(a, 2);

            if (original.Length < n)
            {
                int length = n - original.Length;
                for (int count = 0; count < length; count++)
                {
                    original = original.Insert(0, "0");
                }
            }
            return original;

        }
    }


        class Shor                                                                                    // Алгоритм Шора
        {
            protected Random Random;

            public Shor(Random random)
            {
                this.Random = random;
            }

            public int[] Run(int n, int registerLength)
            {
                int a = this.Random.Next(n);                                                         // 1.	Выбрать число a случайным образом                                                                            
                int greatestCommonDivisor = GreatestCommonDivisor(a, n);                             // 2.	Вычислить НОД (а, N), используя алгоритм Евклида

                if (greatestCommonDivisor != 1)                                                      // Если НОД (а, N) не равен 1, значит существует нетривиальный делитель числа N. Алгоритм завершается
                {
                    //Console.WriteLine("Число " + n + " простое");
                    return new int[] { greatestCommonDivisor };
                }
                //
                int period = this.Period(n, a, registerLength);                                      // 3найти число r, которое является периодом а по модулю N

                if (period % 2 == 1)                                                                 // 4.	Если число r нечетно, тогда вернуться на шаг 1
                {
                    return this.Run(n, registerLength);
                }
                int power = IntPow(a, period / 2);                                                   // 5.	Если аr/2 = -1 mod N, тогда вернуться на шаг 1.
                if (power % n == n - 1)
                {
                    return this.Run(n, registerLength);
                }

                //int[] answer = new int[2];
                //answer[0] = GreatestCommonDivisor(power + 1, n);
                // answer[1] = GreatestCommonDivisor(power - 1, n);
                //6.	Вычислить НОД (аr/2+1, N) и НОД (аr/2-1, N). 
                return new int[] { GreatestCommonDivisor(power + 1, n), GreatestCommonDivisor(power - 1, n) };
            }
            protected static int GreatestCommonDivisor(int a, int b)                                 //	Метод вычисляет НОД (а, N)
            {
                return b == 0 ? a : GreatestCommonDivisor(b, a % b);
            }
            protected static int IntPow(int @base, int exponent)                                      // Метод вычисляет целочисленные степени
            {
                int result = 1;

                while (exponent > 0)
                {
                    if ((exponent & 1) == 1)
                    {
                        result *= @base;
                    }

                    exponent >>= 1;
                    @base *= @base;
                }

                return result;
            }

            //квантовая часть
            public int Period(int n, int a, int registerLength)
            {
                // 2.	Подготовить два квантовых регистра, которые находятся в начальном состоянии |0⟩|0⟩.  
                QuantumRegister inputRegister = new QuantumRegister(0, registerLength);                         // Первый регистр
                QuantumRegister outputRegister = new QuantumRegister(0, registerLength);                        // Второй регистр
                inputRegister = QuantumGate.HadamardGateOfLength(registerLength) * inputRegister;               // 3.	Применить преобразование Адамара к первому регистру 
                Matrix<Complex> modularExponentiationMatrix = ModularExponentiationMatrix(n, a, registerLength);// 4.	Применить унитарный оператор (оракул) 
                QuantumGate modularExponentiationGate = new QuantumGate(modularExponentiationMatrix);
                QuantumRegister fullRegister = new QuantumRegister(inputRegister, outputRegister);
                fullRegister = modularExponentiationGate * fullRegister;
                // 5.	Применить обратное преобразование Фурье к первому регистру
                QuantumGate quantumFourierMatrixPlusIdentity = new QuantumGate(QuantumGate.QuantumFourierTransform(registerLength), QuantumGate.IdentityGateOfLength(registerLength));
                fullRegister = quantumFourierMatrixPlusIdentity * fullRegister;

                fullRegister.Collapse(this.Random);                                                              // 6.	Измеряем первый регистр
                int inputRegisterValue = fullRegister.GetValue(0, registerLength);
                float ratio = (float)inputRegisterValue / (1 << registerLength);                                 //7.	Применить алгоритм цепных дробей 
                int denominator = Denominator(ratio, n);

                for (int period = denominator; period < n; period += denominator)                                //8. 9.	Убедится, что  . Если да, значит rʹ=r, алгоритм завершается. В противном случае выполнить предыдущий шаг с кратным rʹ
                {
                    //if (ShorsAlgorithm.IntPow(a, period) % n == 1)
                    if (ModIntPow(a, period, n) == 1)
                    {
                        return period;
                    }
                }


                return this.Period(n, a, registerLength);                                                         // 10.	В противном случае вернуться ко второму шагу
            }
            protected static Matrix<Complex> ModularExponentiationMatrix(int n, int a, int registerLength)        // Метод для проектирования Оракула
            {
                int matrixSize = 1 << (registerLength * 2);
                Matrix<Complex> modularExponentiationMatrix = Matrix<Complex>.Build.Sparse(matrixSize, matrixSize);

                int blockSize = 1 << registerLength;
                for (int i = 0; i < blockSize; i++)
                {
                    int modularExponentiationResult = ModIntPow(a, i, n);

                    for (int j = 0; j < blockSize; j++)
                    {
                        modularExponentiationMatrix.At(i * blockSize + modularExponentiationResult, i * blockSize + j, 1);
                        
                    }
                }

                return modularExponentiationMatrix;
            }
            protected static int ModIntPow(int @base, int exponent, int modulus)                                  // Метод для модульного возвеления в степень
            {
                int result = 1;

                while (exponent > 0)
                {
                    if ((exponent & 1) == 1)
                    {
                        result = (result * @base) % modulus;
                    }

                    exponent >>= 1;
                    @base = (@base * @base) % modulus;
                }

                return result;
            }
            protected static int Denominator(float realNumber, int maximum)                                       // Метод для Aлгоритма цепных дробей 
            {
                if (realNumber == 0f)
                {
                    return 1;
                }

                int coefficient = 0;
                float remainder = realNumber;

                int[] previousNumerators = new int[] { 0, 1 };
                int[] previousDenominators = new int[] { 1, 0 };

                while (remainder != Math.Floor(remainder))
                {
                    coefficient = (int)remainder;
                    try { remainder = checked(1f / (remainder - coefficient)); }
                    catch (System.OverflowException) { return previousDenominators[1]; }

                    int numerator = coefficient * previousNumerators[1] + previousNumerators[0];
                    int denominator = coefficient * previousDenominators[1] + previousDenominators[0];

                    if (denominator >= maximum)
                    {
                        return previousDenominators[1];
                    }

                    previousNumerators[0] = previousNumerators[1];
                    previousDenominators[0] = previousDenominators[1];
                    previousNumerators[1] = numerator;
                    previousDenominators[1] = denominator;
                }

                return previousDenominators[1];
            }

        }

        class Simon
        {
            protected Random Random;

            public Simon(Random random)
            {
                this.Random = random;
            }
            public string Run(Matrix<Complex> matrixOracle)
            {
                int registerLength = 2;                                                                 // Кол-во кубитов.
                QuantumRegister inputRegister = new QuantumRegister(0, registerLength);                 // Первый регистр (входной)
                QuantumRegister outputRegister = new QuantumRegister(0, registerLength);                // Второй регистр (выходной)

                inputRegister = QuantumGate.HadamardGateOfLength(registerLength) * inputRegister;       // Преобразование Адамара
                QuantumRegister fullRegister = new QuantumRegister(inputRegister, outputRegister);      // Полный регистр
                QuantumGate GateOracle = new QuantumGate(matrixOracle);                                 // Получаем гейт (на основе matrixOracle)
                fullRegister = GateOracle * fullRegister;
                fullRegister = QuantumGate.HadamardGateOfLength(registerLength * 2) * fullRegister;     // Преобразование Адамара
               
                fullRegister.Collapse(this.Random);                                                     // Измерение 
                int inputRegisterValue = fullRegister.GetValue(0, registerLength);                      // Измерение первого ригистра

                string BinaryRegisterValue = HexToBin(inputRegisterValue, registerLength);
                return BinaryRegisterValue;
            }
            private string HexToBin(int a, int n)                                                       // Перевод из 10 в 2 систему и дополнение нулей. n количество кубитов
            {
                string original = Convert.ToString(a, 2);

                if (original.Length < n)
                {
                    int length = n - original.Length;
                    for (int count = 0; count < length; count++)
                    {
                        original = original.Insert(0, "0");
                    }
                }
                return original;
            }
        }
    }


