using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Platinum
{
    public class CodeAction : ActionBase
    {
        public ActionResult Execute()
        {
            var codedomprovider = System.CodeDom.Compiler.CodeDomProvider.CreateProvider("c#");

            var compilerParameters = new CompilerParameters() { GenerateInMemory = true };

            var results = codedomprovider.CompileAssemblyFromSource(compilerParameters, this.SourceText);

            this._compiledCode = new CompiledCode()
            {
                Assembly = results.CompiledAssembly
                ,
                Type = results.CompiledAssembly.GetType("CodeAction")
                ,
                MethodInfo = results.CompiledAssembly.GetType("CodeAction").GetMethod("Execute")
            };

            return Continue();
        }

        private CompiledCode _compiledCode;

        public string SourceText
        {
            get;
            set;
        }

    }

    internal class CompiledCode
    {
        public Assembly Assembly;
        public Type Type;
        public MethodInfo MethodInfo;

        
    }
}
