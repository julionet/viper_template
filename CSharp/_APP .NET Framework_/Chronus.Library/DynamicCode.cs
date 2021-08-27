using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.CodeDom.Compiler;

namespace Chronus.Library
{
    public class DynamicCode
    {
        private bool _generateexecutable = false;
        public bool GenerateExecutable
        {
            get { return _generateexecutable; }
            set { _generateexecutable = value; }
        }

        private string _executablename;
        public string ExecutableName
        {
            get { return _executablename; }
            set { _executablename = value; }
        }

        private string _languagename;
        public string LanguageName
        {
            get { return _languagename; }
            set { _languagename = value; }
        }

        private List<string> _assemblys = new List<string>();
        public List<string> Assemblys
        {
            get { return _assemblys; }
            set { _assemblys = value; }
        }

        private List<object> _parameters = new List<object>();
        public List<object> Parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }

        private string _instancename;
        public string InstanceName 
        {
            get { return _instancename; }
            set { _instancename = value; }
        }

        private string _methodname;
        public string MethodName
        {
            get { return _methodname; }
            set { _methodname = value; }
        }

        private string _code;
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public DynamicCode()
        {
        }

        public bool Execute(ref object retorno, ref string mensagem)
        {
            mensagem = ValidateProperties();
            if (mensagem != "")
                return false;
            else
            {
                CodeDomProvider provider = CodeDomProvider.CreateProvider(_languagename);
                CompilerParameters cp = new CompilerParameters();
                foreach (string s in _assemblys)
                    cp.ReferencedAssemblies.Add(s);
                cp.GenerateInMemory = false;
                cp.GenerateExecutable = _generateexecutable;
                cp.OutputAssembly = _executablename;
                
                CompilerResults loCompiled = provider.CompileAssemblyFromSource(cp, _code);
                if (loCompiled.Errors.HasErrors)
                {
                    mensagem = "";
                    mensagem = loCompiled.Errors.Count.ToString() + " Errors:";
                    for (int x = 0; x < loCompiled.Errors.Count; x++)
                        mensagem += "\r\nLine: " + loCompiled.Errors[x].Line.ToString() + " - " + loCompiled.Errors[x].ErrorText;
                    mensagem += "\r\n\r\n" + _code;
                    return false;
                }
                else
                {
                    if (!_generateexecutable)
                    {
                        Assembly loAssembly = loCompiled.CompiledAssembly;
                        object loObject = loAssembly.CreateInstance(_instancename);
                        if (loObject == null)
                        {
                            mensagem = "Não foi possível carregar a classe " + _instancename + "!";
                            return false;
                        }
                        else
                        {
                            object[] loParameters = null;
                            if (_parameters.Count > 0)
                            {
                                loParameters = new object[_parameters.Count];
                                int i = 0;
                                foreach (object o in _parameters)
                                {
                                    loParameters[i] = o;
                                    i++;
                                }
                            }

                            try
                            {
                                object loResult = loObject.GetType().InvokeMember(_methodname, BindingFlags.InvokeMethod, null, loObject, loParameters);
                                retorno = loResult;
                            }
                            catch (Exception erro)
                            {
                                mensagem = erro.Message;
                                return false;
                            }
                        }
                    }
                    else
                    {
                        retorno = "";
                        return true;
                    }
                }
            }
            return true;
        }

        private string ValidateProperties()
        {
            if (string.IsNullOrWhiteSpace(_instancename))
                return "Nome da instância não foi definido!";
            else if (string.IsNullOrWhiteSpace(_languagename))
                return "Nome da linguagem não foi definido!";
            else if (string.IsNullOrWhiteSpace(_methodname))
                return "Nome do método não foi definido!";
            else if (string.IsNullOrWhiteSpace(_code))
                return "Código fonte não foi definido!";
            else
                return "";
        }
    }
}
