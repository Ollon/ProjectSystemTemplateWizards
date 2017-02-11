// ----------------------------------------------------------------------------
//  <copyright file="DocumentGenerator.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Generators
{
    internal static class DocumentGenerator
    {
        public static Document GenerateDocument(Project project,string name, SyntaxNode root, IEnumerable<string> folders)
        {
            if (!name.EndsWith(".cs"))
                name += ".cs";
            DocumentId documentId = DocumentId.CreateNewId(project.Id);
            
            return project.AddDocument(name, root.GetText(), folders);
        }

    }
}