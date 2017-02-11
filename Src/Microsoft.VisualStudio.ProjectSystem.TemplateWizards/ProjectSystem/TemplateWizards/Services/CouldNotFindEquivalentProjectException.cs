// ----------------------------------------------------------------------------
//  <copyright file="CouldNotFindEquivalentProjectException.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System;

namespace Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Services
{
    public class CouldNotFindEquivalentProjectException : Exception
    {
        public CouldNotFindEquivalentProjectException(string roslynProjectName) : base(roslynProjectName)
        {
        }
    }
}