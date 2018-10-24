using System.Text;

namespace Profiling
{
    internal class Generator
    {
        public static string GenerateDeclarations()
        {
            var result = new StringBuilder();
            foreach (var fieldCount in Constants.FieldCounts)
            {
                var stringBuilder = new StringBuilder();
                GenerateClassesAndStructs(result, fieldCount, stringBuilder);
                result.AppendLine();
            }

            return result.ToString();
        }

        private static void GenerateClassesAndStructs(StringBuilder result, int fieldCount, StringBuilder stringBuilder)
        {
            for (var i = 0; i < fieldCount; i++)
                stringBuilder.Append($"byte Value{i}; ");

            result.Append($@"struct S{fieldCount}
                                {{
                                {stringBuilder}
                                }}");
            result.AppendLine();
            result.Append($@"class C{fieldCount}
                                {{
                                {stringBuilder}
                                }}");
        }

        public static string GenerateArrayRunner()
        {
            var result = new StringBuilder();
            result.Append(@"public class ArrayRunner : IRunner{");
            GenerateFunctions(result);

            GenerateCallerFunction(result);
            result.Append("}");
            return result.ToString();
        }

        private static void GenerateFunctions(StringBuilder result)
        {
            foreach (var fieldCount in Constants.FieldCounts)
                result.Append($@"void PC{fieldCount}()
                                {{
                                   var array = new C{fieldCount}[{Constants.ArraySize}];
                                   for (int i = 0; i < Constants.ArraySize; i++) array[i] = new C{fieldCount}();
                                }}

                                void PS{fieldCount}()
                                {{
                                    var array = new S{fieldCount}[{Constants.ArraySize}];
                                }}");
        }

        private static void GenerateCallerFunction(StringBuilder result)
        {
            result.Append(@"public void Call(bool isClass, int size, int count){");

            foreach (var fieldCount in Constants.FieldCounts)
                result.Append($@"if (isClass && size == {fieldCount})
                                 {{
                                    for (int i = 0; i < count; i++) PC{fieldCount}();
                                    return;
                                 }}
                                if (!isClass && size == {fieldCount})
                                {{
                                    for (int i = 0; i < count; i++) PS{fieldCount}();
                                    return;
                                }}");

            result.Append("throw new ArgumentException(); \n}");
        }

        public static string GenerateCallRunner()
        {
            var result = new StringBuilder();
            result.Append(@"public class CallRunner : IRunner{");
            GenerateEmptyMethods(result);

            GenerateCallerMethodWithAllocation(result);
            result.Append("}");
            return result.ToString();
        }

        private static string GenerateEmptyMethods(StringBuilder result)
        {
            foreach (var fieldCount in Constants.FieldCounts)
                result.Append($@"void PC{fieldCount}(C{fieldCount} o)
                                {{ }}

                                void PS{fieldCount}(S{fieldCount} o)
                                {{ }}");
            return result.ToString();
        }

        private static string GenerateCallerMethodWithAllocation(StringBuilder result)
        {
            result.Append(@"public void Call(bool isClass, int size, int count){");


            foreach (var fieldCount in Constants.FieldCounts)
                result.Append($@"if (isClass && size == {fieldCount})
                                 {{
                                    var o = new C{fieldCount}(); 
                                    for (int i = 0; i < count; i++) PC{fieldCount}(o);
                                    return;
                                 }}
                                if (!isClass && size == {fieldCount})
                                {{
                                    var o = new S{fieldCount}(); 
                                    for (int i = 0; i < count; i++) PS{fieldCount}(o);
                                    return;
                                }}");

            result.Append("throw new ArgumentException(); \n}");
            return result.ToString();
        }
    }
}