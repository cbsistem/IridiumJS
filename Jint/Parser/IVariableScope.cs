using System.Collections.Generic;
using IridiumJS.Parser.Ast;

namespace IridiumJS.Parser
{
    /// <summary>
    /// Used to safe references to all variable delcarations in a specific scope.
    /// Hoisting.
    /// </summary>
    public interface IVariableScope
    {
        IList<VariableDeclaration> VariableDeclarations { get; set; }
    }

    public class VariableScope : IVariableScope
    {
        public VariableScope()
        {
            VariableDeclarations = new List<VariableDeclaration>();
        }

        public IList<VariableDeclaration> VariableDeclarations { get; set; }
    }
}