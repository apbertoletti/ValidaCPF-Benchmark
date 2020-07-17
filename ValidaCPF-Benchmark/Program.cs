using Arcnet.MyConvert;
using Dlp.Framework;
using System;
using System.Diagnostics;

namespace ValidaCPF_Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            Package1();
            Package2();
            Package3();
            Package4();
            Package5();
            Package6();
            Package7();
            Package8();
            //Package9(); Muito lento

            Console.ReadKey();
        }

        private static void Package1()
        {
            Console.WriteLine("============= COMPONENTE 1: https://www.nuget.org/packages/Cpf ============");
            
            var before0 = GC.CollectionCount(0);
            var before1 = GC.CollectionCount(1);
            var before2 = GC.CollectionCount(2);

            var sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i <= 1_000_000; i++)
            {
                //Testa um CPF válido para garantir o funcionamento do componente
                if (!CpfLibrary.Cpf.Check("313.805.220-72"))
                    throw new FormatException("Incorrect validation");

                //Testa um CPF inválido para garantir o funcionamento do componente
                if (CpfLibrary.Cpf.Check("313.805.220-00"))
                    throw new FormatException("Incorrect invalidation");
            }

            sw.Stop();

            Console.WriteLine($"\nTime: {sw.ElapsedMilliseconds} ms");
            Console.WriteLine($"# Gen0: {GC.CollectionCount(0) - before0}");
            Console.WriteLine($"# Gen1: {GC.CollectionCount(1) - before1}");
            Console.WriteLine($"# Gen1: {GC.CollectionCount(2) - before2}");
            Console.WriteLine($"# Memory: {Process.GetCurrentProcess().WorkingSet64 / 1024 / 1024} mb");
            Console.WriteLine();
        }

        private static void Package2()
        {
            Console.WriteLine("============= COMPONENTE 2: https://www.nuget.org/packages/Scorpion.CpfAnaliser/ ============");

            var before0 = GC.CollectionCount(0);
            var before1 = GC.CollectionCount(1);
            var before2 = GC.CollectionCount(2);

            var sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i <= 1_000_000; i++)
            {
                //Testa um CPF válido para garantir o funcionamento do componente
                if (!Cpf.CpfAnaliser.ValidateCpf("313.805.220-72"))
                    throw new FormatException("Incorrect validation");

                //Testa um CPF inválido para garantir o funcionamento do componente
                if (Cpf.CpfAnaliser.ValidateCpf("313.805.220-00"))
                    throw new FormatException("Incorrect invalidation");
            }

            sw.Stop();

            Console.WriteLine($"\nTime: {sw.ElapsedMilliseconds} ms");
            Console.WriteLine($"# Gen0: {GC.CollectionCount(0) - before0}");
            Console.WriteLine($"# Gen1: {GC.CollectionCount(1) - before1}");
            Console.WriteLine($"# Gen1: {GC.CollectionCount(2) - before2}");
            Console.WriteLine($"# Memory: {Process.GetCurrentProcess().WorkingSet64 / 1024 / 1024} mb");
            Console.WriteLine();
        }

        private static void Package3()
        {
            Console.WriteLine("============= COMPONENTE 3: https://www.nuget.org/packages/Valida.CPF.CNPJ ============");

            var before0 = GC.CollectionCount(0);
            var before1 = GC.CollectionCount(1);
            var before2 = GC.CollectionCount(2);

            var sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i <= 1_000_000; i++)
            {
                //Testa um CPF válido para garantir o funcionamento do componente
                if (!Valida.CPF.CNPJ.ValidaCPFCNPJ.ValidaCPF("313.805.220-72"))
                    throw new FormatException("Incorrect validation");

                //Testa um CPF inválido para garantir o funcionamento do componente
                if (Valida.CPF.CNPJ.ValidaCPFCNPJ.ValidaCPF("313.805.220-00"))
                    throw new FormatException("Incorrect invalidation");
            }

            sw.Stop();

            Console.WriteLine($"\nTime: {sw.ElapsedMilliseconds} ms");
            Console.WriteLine($"# Gen0: {GC.CollectionCount(0) - before0}");
            Console.WriteLine($"# Gen1: {GC.CollectionCount(1) - before1}");
            Console.WriteLine($"# Gen1: {GC.CollectionCount(2) - before2}");
            Console.WriteLine($"# Memory: {Process.GetCurrentProcess().WorkingSet64 / 1024 / 1024} mb");
            Console.WriteLine();
        }

        private static void Package4()
        {
            Console.WriteLine("============= COMPONENTE 4: https://www.nuget.org/packages/validationCpf ============");

            var before0 = GC.CollectionCount(0);
            var before1 = GC.CollectionCount(1);
            var before2 = GC.CollectionCount(2);

            var sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i <= 1_000_000; i++)
            {
                //Testa um CPF válido para garantir o funcionamento do componente
                if (!ValidationBasic.Validation.validationCpf("31380522072"))
                    throw new FormatException("Incorrect validation");

                //Testa um CPF inválido para garantir o funcionamento do componente
                if (ValidationBasic.Validation.validationCpf("31380522000"))
                    throw new FormatException("Incorrect invalidation");
            }

            sw.Stop();

            Console.WriteLine($"\nTime: {sw.ElapsedMilliseconds} ms");
            Console.WriteLine($"# Gen0: {GC.CollectionCount(0) - before0}");
            Console.WriteLine($"# Gen1: {GC.CollectionCount(1) - before1}");
            Console.WriteLine($"# Gen1: {GC.CollectionCount(2) - before2}");
            Console.WriteLine($"# Memory: {Process.GetCurrentProcess().WorkingSet64 / 1024 / 1024} mb");
            Console.WriteLine();
        }

        private static void Package5()
        {
            Console.WriteLine("============= COMPONENTE 5: https://www.nuget.org/packages/CPFCNPJ ============");

            var before0 = GC.CollectionCount(0);
            var before1 = GC.CollectionCount(1);
            var before2 = GC.CollectionCount(2);

            var sw = new Stopwatch();
            sw.Start();

            var validator = new CPFCNPJ.Main();

            for (int i = 0; i <= 1_000_000; i++)
            {
                //Testa um CPF válido para garantir o funcionamento do componente
                if (!validator.IsValidCPFCNPJ("31380522072"))
                    throw new FormatException("Incorrect validation");

                //Testa um CPF inválido para garantir o funcionamento do componente
                if (validator.IsValidCPFCNPJ("31380522000"))
                    throw new FormatException("Incorrect invalidation");
            }

            sw.Stop();

            Console.WriteLine($"\nTime: {sw.ElapsedMilliseconds} ms");
            Console.WriteLine($"# Gen0: {GC.CollectionCount(0) - before0}");
            Console.WriteLine($"# Gen1: {GC.CollectionCount(1) - before1}");
            Console.WriteLine($"# Gen1: {GC.CollectionCount(2) - before2}");
            Console.WriteLine($"# Memory: {Process.GetCurrentProcess().WorkingSet64 / 1024 / 1024} mb");
            Console.WriteLine();
        }

        private static void Package6()
        {
            Console.WriteLine("============= COMPONENTE 6: https://www.nuget.org/packages/Maoli ============");

            var before0 = GC.CollectionCount(0);
            var before1 = GC.CollectionCount(1);
            var before2 = GC.CollectionCount(2);

            var sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i <= 1_000_000; i++)
            {
                //Testa um CPF válido para garantir o funcionamento do componente
                if (!Maoli.Cpf.Validate("313.805.220-72"))
                    throw new FormatException("Incorrect validation");

                //Testa um CPF inválido para garantir o funcionamento do componente
                if (Maoli.Cpf.Validate("313.805.220-00"))
                    throw new FormatException("Incorrect invalidation");
            }

            sw.Stop();

            Console.WriteLine($"\nTime: {sw.ElapsedMilliseconds} ms");
            Console.WriteLine($"# Gen0: {GC.CollectionCount(0) - before0}");
            Console.WriteLine($"# Gen1: {GC.CollectionCount(1) - before1}");
            Console.WriteLine($"# Gen1: {GC.CollectionCount(2) - before2}");
            Console.WriteLine($"# Memory: {Process.GetCurrentProcess().WorkingSet64 / 1024 / 1024} mb");
            Console.WriteLine();
        }

        private static void Package7()
        {
            Console.WriteLine("============= COMPONENTE 7: https://www.nuget.org/packages/MyConvert/ ============");

            var before0 = GC.CollectionCount(0);
            var before1 = GC.CollectionCount(1);
            var before2 = GC.CollectionCount(2);

            var sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i <= 1_000_000; i++)
            {
                //Testa um CPF válido para garantir o funcionamento do componente
                if (!MyCheck.CheckCpf("313.805.220-72"))
                    throw new FormatException("Incorrect validation");

                //Testa um CPF inválido para garantir o funcionamento do componente
                if (MyCheck.CheckCpf("313.805.220-00"))
                    throw new FormatException("Incorrect invalidation");
            }

            sw.Stop();

            Console.WriteLine($"\nTime: {sw.ElapsedMilliseconds} ms");
            Console.WriteLine($"# Gen0: {GC.CollectionCount(0) - before0}");
            Console.WriteLine($"# Gen1: {GC.CollectionCount(1) - before1}");
            Console.WriteLine($"# Gen1: {GC.CollectionCount(2) - before2}");
            Console.WriteLine($"# Memory: {Process.GetCurrentProcess().WorkingSet64 / 1024 / 1024} mb");
            Console.WriteLine();
        }

        private static void Package8()
        {
            Console.WriteLine("============= COMPONENTE 8: https://www.nuget.org/packages/Dlp.Framework.dll ============");

            var before0 = GC.CollectionCount(0);
            var before1 = GC.CollectionCount(1);
            var before2 = GC.CollectionCount(2);

            var sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i <= 1_000_000; i++)
            {
                //Testa um CPF válido para garantir o funcionamento do componente
                if (!"313.805.220-72".IsValidCpf())
                    throw new FormatException("Incorrect validation");

                //Testa um CPF inválido para garantir o funcionamento do componente
                if ("313.805.220-00".IsValidCpf())
                    throw new FormatException("Incorrect invalidation");
            }

            sw.Stop();

            Console.WriteLine($"\nTime: {sw.ElapsedMilliseconds} ms");
            Console.WriteLine($"# Gen0: {GC.CollectionCount(0) - before0}");
            Console.WriteLine($"# Gen1: {GC.CollectionCount(1) - before1}");
            Console.WriteLine($"# Gen1: {GC.CollectionCount(2) - before2}");
            Console.WriteLine($"# Memory: {Process.GetCurrentProcess().WorkingSet64 / 1024 / 1024} mb");
            Console.WriteLine();
        }

        private static void Package9()
        {
            Console.WriteLine("============= COMPONENTE 9: https://www.nuget.org/packages/Caelum.Stella.CSharp ============");

            var before0 = GC.CollectionCount(0);
            var before1 = GC.CollectionCount(1);
            var before2 = GC.CollectionCount(2);

            var sw = new Stopwatch();
            sw.Start();

            var validator = new Caelum.Stella.CSharp.Validation.CPFValidator();

            for (int i = 0; i <= 1_000_000; i++)
            {
                //Testa um CPF válido para garantir o funcionamento do componente
                if (!validator.IsValid("313.805.220-72"))
                    throw new FormatException("Incorrect validation");

                //Testa um CPF inválido para garantir o funcionamento do componente
                if (validator.IsValid("313.805.220-00"))
                    throw new FormatException("Incorrect invalidation");
            }

            sw.Stop();

            Console.WriteLine($"\nTime: {sw.ElapsedMilliseconds} ms");
            Console.WriteLine($"# Gen0: {GC.CollectionCount(0) - before0}");
            Console.WriteLine($"# Gen1: {GC.CollectionCount(1) - before1}");
            Console.WriteLine($"# Gen1: {GC.CollectionCount(2) - before2}");
            Console.WriteLine($"# Memory: {Process.GetCurrentProcess().WorkingSet64 / 1024 / 1024} mb");
            Console.WriteLine();
        }
    }
}
